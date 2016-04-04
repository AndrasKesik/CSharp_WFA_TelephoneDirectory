using System;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Contacts : Form
    {
        TelephoneDictionary telephoneDictionary = new TelephoneDictionary();
        public Contacts()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Type)))
            {
                this.comboBox1.Items.Add(item);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                person.name = textBox1.Text;
                person.address = textBox2.Text;
                person.age = Int32.Parse(textBox3.Text);
                person.telephoneNumber = textBox4.Text;
                person.Type = (Type) Enum.Parse(typeof (Type), comboBox1.Text, true);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.ResetText();
                telephoneDictionary.AddPerson(person);
                var listViewItem = new ListViewItem(person.ToString());
                listBox1.Items.Add(listViewItem.ToString());
            }
            catch
            {
                MessageBox.Show("Wrong input try again.\nAge: Int\nOthers: string");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.ResetText();

            }

        }

        private void list_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(700, 291);
            listBox1_SelectedIndexChanged();
            listBox1.Items.Clear();
            foreach (var i in telephoneDictionary)
            {
                var listViewItem = new ListViewItem(i.ToString());
                listBox1.Items.Add(listViewItem.ToString());
            }
            

        }

        private void listBox1_SelectedIndexChanged()
        {
            this.ClientSize = new System.Drawing.Size(850, 291);
            this.Controls.Add(this.listBox1);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(309, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 238);
            this.listBox1.TabIndex = 12;
        }
    }
}
