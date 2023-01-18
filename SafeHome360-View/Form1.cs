using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SafeHome360_View
{
    public partial class main : Form
    {
        private SerialPort com;
        static public string message; 
        
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.com = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            this.com.ReceivedBytesThreshold = 3;
            this.com.DataReceived += byter;
            this.com.Open();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Histories objForm = new Histories();
            objForm.TopLevel = false;
            panHistories.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
           
           
        }

        private void byter(object sender, SerialDataReceivedEventArgs e)
        {
            int d1 = this.com.ReadByte();
            int d2 = this.com.ReadByte();
            int d3 = this.com.ReadByte();
            findAndShow(d1, d2, d3);
        }

        private void findAndShow(int type, int numero, int status)
        {
            string name;
            string typeName = "";
            if (type == 0)
            {
                 name = "btnF";
                 typeName = "Fenetre";
            }
            else if(type==1)
            {
                 name = "btnP";
                typeName = "Portre";

            }
            else if (type == 2)
            {
                 name = "btnM";
            }
            else
            {
                name = "btnI";
            }

            name = name + numero;

            Control[] c =  this.Controls.Find(name,true);
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)c[0];

            if (status == 1)
            {
                
                b.BackColor = System.Drawing.Color.Red;
                message = "La " + typeName + " est ouverte";
            }
            else
            {
                if (type == 0)
                {
                    b.BackColor = System.Drawing.Color.LightSlateGray;
                }
                else if (type == 1)
                {
                    b.BackColor = System.Drawing.Color.LightCyan;
                }
                else if (type == 2)
                {
                    //name = "btnM";
                }
                else
                {
                   // name = "btnI";
                }
                message = "La " + typeName + " est fermer";
            }

        }


        private void btnF1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnP3_Click(object sender, EventArgs e)
        {

        }

        private void statusText_Click(object sender, EventArgs e)
        {
           // statusMessage.Text = "22";
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Displays the MessageBox.
            string message = "Voulez-vous vraiment fermer l'application ?";
            string caption = "Fermeture de l'application";
            MessageBoxButtons Button = MessageBoxButtons.YesNo;
            var  result = MessageBox.Show(message, caption, Button);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                close();
            }
            else
            {

            }

            
        }

        private void close()
        {
            main m = new main();
            m.Close();

            try
            {
                if (com.IsOpen == true)
                {
                    this.com.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
