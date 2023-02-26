using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddForm : Form
    {
        public Note MyRecord;
        public AddForm(Note _MyRecord)
        {
            InitializeComponent();
            MyRecord = _MyRecord;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // определяем поля записи -
            // берем значения из соответствующих компонентов на форме
            MyRecord.LastName = LastNameTextBox.Text;
            MyRecord.Name = NameTextBox.Text;
            MyRecord.Patronymic = PatronymicTextBox.Text;
            MyRecord.Phone = PhoneMaskedTextBox.Text;
            MyRecord.Street = StreetTextBox.Text;
            MyRecord.House = (ushort)HouseNumericUpDown.Value;
            MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
            Close(); 		// закрываем форму

        }
    }
}
