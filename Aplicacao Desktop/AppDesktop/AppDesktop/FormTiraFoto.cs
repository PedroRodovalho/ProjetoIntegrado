using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AppDesktop.DAO;

namespace AppDesktop
{
    public partial class FormTiraFoto : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        private FormCadastra_cliente fCliente = null;

        private string nome;

        public FormTiraFoto(FormCadastra_cliente fCliente)
        {
            InitializeComponent();
            this.fCliente = fCliente;
        }

        private void FormTiraFoto_Load(object sender, EventArgs e)
        {
            //código do carregamento (load) do Form
            //lista os dispositivos de captura de imagem do computador/notebook
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                comboBox1.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
                comboBox1.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                comboBox1.Items.Add("Nenhum dispositivo encontrado!");
            }



            if (DeviceExist)
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
                {


                    string resolution_size = videoSource.VideoCapabilities[i].FrameSize.ToString();
                    comboBox2.Items.Add(resolution_size);
                }
                //Encerra o sinal da camera.
                if (!(videoSource == null))
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource = null;
                    }
                videoSource.VideoResolution = videoSource.VideoCapabilities[2];
                //videoSource.DesiredFrameSize = new Size(160, 120);
                // videoSource.DesiredFrameRate = 10;
                videoSource.Start();

            }
            else
            {
                MessageBox.Show("Nenhum dispositivo encontrado!");
            }


        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                //Encerra o sinal da camera.
                // Note que este bloco de código se repetiu, você pode cirar um método para ele.
                if (!(videoSource == null))
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource = null;
                        
                        
                        /*
                        // salva a imagem;
                        saveFileDialog1.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
                        DialogResult res = saveFileDialog1.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }*/

                    }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            fCliente.pictureBox_foto_cliente.Image = pictureBox1.Image;

        }

        private void btn_def_resolution_Click(object sender, EventArgs e)
        {
            int index_resolution = comboBox2.SelectedIndex;
            videoSource.Stop();
            videoSource.VideoResolution = videoSource.VideoCapabilities[index_resolution];
            videoSource.Start();
        }
    }
}


