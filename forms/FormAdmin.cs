using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoMarjorie.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using ProyectoMarjorie.database;
using System.IO;

namespace ProyectoMarjorie.forms
{
    public partial class FormAdmin : MaterialForm
    {
        public FormAdmin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeDataGridView();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Obtener todas las peticiones
            List<Peticion> peticiones = DatabaseHelper.ObtenerTodasLasPeticiones();

            // Limpiar el DataGridView antes de agregar nuevos datos
            dgvPetList.Rows.Clear();

            // Agregar las peticiones al DataGridView
            foreach (var peticion in peticiones)
            {
                // Aquí agregas la información que deseas mostrar
                dgvPetList.Rows.Add(peticion.Id, peticion.Estudiante.Nombre, peticion.Fecha.ToString("dd/MM/yyyy"), peticion.ClasesSeleccionadas.Count);
            }
        }

        private void ActivateAddButton()
        {
            if (tbCifSendPet.Text != "" && tbUsername.Text != "" && cbJustDateCompletion.Checked == true)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            cbName.Checked = true;
            ActivateAddButton();
        }

        private void tbCifSendPet_TextChanged(object sender, EventArgs e)
        {
            cbCifCompletion.Checked = true;
            ActivateAddButton();
        }

        private void activateProfessorBotons()
        {
            if (tbProfessorName.Text != "" && tbProfessorEmail.Text != "")
            {
                mepAddProfessor.ValidationButtonEnable = true;
                btnAddOtherProfessor.Enabled = true;
            }
            else
            {
                mepAddProfessor.ValidationButtonEnable = false;
                btnAddOtherProfessor.Enabled = false;
            }
        }
        
        private void tbProfessorName_TextChanged(object sender, EventArgs e)
        {
            cbProfessorName.Checked = true;

            activateProfessorBotons();

            if (tbProfessorName.Text == "")
            {
                cbProfessorName.Checked = false;
            }
        }

        private void tbProfessorEmail_TextChanged(object sender, EventArgs e)
        {
            cbProfessorEmailCompletion.Checked = true;

            activateProfessorBotons();

            if (tbProfessorEmail.Text == "")
            {
                cbProfessorEmailCompletion.Checked = false;
            }
        }

        private void dtpStudenBirthDate_ValueChanged(object sender, EventArgs e)
        {
            cbJustDateCompletion.Checked = true;
            ActivateAddButton();
        }

        //Funcion para activar el botón para mandar la justificación
        private void checkCompletion()
        {
            if (cbJustDateCompletion.Checked == true && cbCifCompletion.Checked == true && cbProfessorName.Checked == true && cbProfessorEmailCompletion.Checked == true && cbName.Checked == true)
            {
                mepSendJustNotice.ValidationButtonEnable = true;
            }
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbCifCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbProfessorName_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbProfessorEmailCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void cbJustDateCompletion_CheckedChanged(object sender, EventArgs e)
        {
            checkCompletion();
        }

        private void mepAddProfessor_CancelClick(object sender, EventArgs e)
        {
            tbProfessorName.Text = "";
            tbProfessorEmail.Text = "";
            
        }

        private void mepAddProfessor_SaveClick(object sender, EventArgs e)
        {
            //Agregar función para agregar profesor al string de correo
        }

        private void btnAddOtherProfessor_Click(object sender, EventArgs e)
        {
            tbProfessorName.Text = "";
            tbProfessorEmail.Text = "";
        }

        private void mepJustDetails_CancelClick(object sender, EventArgs e)
        {
            mepJustDetails.Collapse = true;
            mepRejectedPet.Collapse = false;
        }

        private void mepRejectedPet_CancelClick(object sender, EventArgs e)
        {
            mepJustDetails.Collapse = false;
            mepRejectedPet.Collapse = true;
        }

        public static List<Peticion> ObtenerPeticiones()
        {
            List<Peticion> peticiones = new List<Peticion>();

            // Conexión a la base de datos
            using (var conexion = new SQLiteConnection(DatabaseHelper.DatabasePath))
            {
                conexion.Open();

                // Consulta para obtener las peticiones
                string queryPeticiones = @"
    SELECT p.IdPeticion, p.Fecha, p.CifEstudiante, p.Imagen
    FROM Peticiones p";

                // Consulta para obtener las clases asociadas a cada petición
                string queryClases = @"
    SELECT c.Nombre, c.NombreProfesor, c.CorreoProfesor
    FROM Clases c
    JOIN ClasesPeticiones cp ON cp.IdClase = c.IdClase
    WHERE cp.IdPeticion = @IdPeticion";

                using (var cmdPeticiones = new SQLiteCommand(queryPeticiones, conexion))
                {
                    using (var readerPeticiones = cmdPeticiones.ExecuteReader())
                    {
                        while (readerPeticiones.Read())
                        {
                            var peticion = new Peticion
                            {
                                Id = readerPeticiones.GetInt32(0),
                                Fecha = readerPeticiones.GetDateTime(1),
                                // Llamar a ObtenerEstudiantePorCif de forma estática
                                Estudiante = DatabaseHelper.ObtenerEstudiantePorCif(readerPeticiones.GetInt32(2).ToString()),
                                Imagen = readerPeticiones["Imagen"] as byte[],
                                ClasesSeleccionadas = new List<Clase>() // Inicializamos la lista de clases
                            };

                            // Obtener las clases asociadas a esta petición
                            using (var cmdClases = new SQLiteCommand(queryClases, conexion))
                            {
                                cmdClases.Parameters.AddWithValue("@IdPeticion", peticion.Id);
                                using (var readerClases = cmdClases.ExecuteReader())
                                {
                                    while (readerClases.Read())
                                    {
                                        peticion.ClasesSeleccionadas.Add(new Clase
                                        {
                                            Nombre = readerClases.GetString(0),
                                            NombreProfesor = readerClases.GetString(1),
                                            CorreoProfesor = readerClases.GetString(2)
                                        });
                                    }
                                }
                            }

                            // Añadir la petición a la lista
                            peticiones.Add(peticion);
                        }
                    }
                }
            }

            return peticiones;
        }



        private void InitializeDataGridView()
        {
            if (dgvPetList.Columns.Count == 0)
            {
                dgvPetList.Columns.Add("PeticionId", "ID");
                dgvPetList.Columns.Add("EstudianteNombre", "Estudiante");
                //dgvPetList.Columns.Add("ClaseNombre", "Clase");
                dgvPetList.Columns.Add("Fecha", "Fecha");
                //dgvPetList.Columns.Add("ProfesorNombre", "Profesor");
            }
        }

        private void dgvPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0 && e.RowIndex < dgvPetList.Rows.Count)
            {
                var row = dgvPetList.Rows[e.RowIndex];

                // Asignar valores de la fila seleccionada a los TextBox
                tbName.Text = row.Cells["EstudianteNombre"].Value?.ToString() ?? "";
                //tbCif.Text = row.Cells["PeticionId"].Value?.ToString() ?? ""; // Ajusta según dónde guardes el CIF
                tbDate.Text = row.Cells["Fecha"].Value?.ToString() ?? "";

                // Aquí obtendremos las clases asociadas y las uniremos en un string
                int peticionId = int.Parse(row.Cells["PeticionId"].Value?.ToString() ?? "0");
                var peticion = DatabaseHelper.ObtenerPeticion(peticionId);

                if (peticion != null && peticion.ClasesSeleccionadas != null)
                {
                    tbClass.Text = string.Join(", ", peticion.ClasesSeleccionadas.Select(c => c.Nombre));
                    tbCif.Text = peticion.Estudiante.Cif.ToString();
                }
                else
                {
                    tbClass.Text = "No hay clases asociadas";
                }

                // Propagar datos al MaterialMultiLineTextBox (mlblEmailPreview)
                string nombreEstudiante = tbName.Text;
                string fecha = tbDate.Text;

                mlblEmailPreview.Text = $@"Buenos días estimados docentes y coordinadores:

                    Agradeceremos el apoyo justificando la inasistencia del estudiante {nombreEstudiante}, quien faltó a clases desde el {fecha} por motivos de salud. Cabe señalar que esta inasistencia se suma al 20% que el estudiante tiene para ser justificado, si se llega a sobrepasar este 20% pierde el derecho a realizar examen final del curso.

                    {nombreEstudiante} se compromete a ponerse al día con las tareas y clases pendientes. Aprovechamos el presente para solicitar el apoyo con recibir tareas o trabajos pendientes de manera tardía.";
            }
        }

        private void mepJustDetails_SaveClick(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de la petición seleccionada
                if (dgvPetList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una petición.");
                    return;
                }

                int idPeticion = Convert.ToInt32(dgvPetList.SelectedRows[0].Cells["PeticionId"].Value);

                // Obtener los correos asociados a la petición
                var correos = DatabaseHelper.ObtenerCorreosProfesoresPorPeticion(idPeticion);

                if (correos.Count == 0)
                {
                    MessageBox.Show("No se encontraron correos para las clases asociadas a esta petición.");
                    return;
                }

                // Configuración de Gmail
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("admin_email@gmail.com", "admin_password"),
                    EnableSsl = true,
                };

                // Crear el mensaje
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("admin_email@gmail.com"),
                    Subject = "Justificación de inasistencia",
                    Body = mlblEmailPreview.Text,
                    IsBodyHtml = false,
                };

                // Agregar destinatarios
                foreach (var correo in correos)
                {
                    mailMessage.To.Add(correo);
                }

                // Adjuntar imagen de justificación
                var peticion = DatabaseHelper.ObtenerPeticion(idPeticion);
                if (peticion.Imagen != null && peticion.Imagen.Length > 0)
                {
                    using (var stream = new MemoryStream(peticion.Imagen))
                    {
                        var attachment = new Attachment(stream, "justificacion.jpg", "image/jpeg");
                        mailMessage.Attachments.Add(attachment);
                    }
                }

                // Enviar el correo
                smtpClient.Send(mailMessage);

                MessageBox.Show("El correo fue enviado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }
    }

}
