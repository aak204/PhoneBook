using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Note
    {
        public string LastName;
        public string Name;
        public string Patronymic;
        public string Street;
        public ushort House;
        public ushort Flat;
        public string Phone;
        /// <summary>
        /// Если все поля одинаковы, метод возвращает false. Если хотя бы одно поле отличается, метод возвращает true, 
        /// указывая на то, что объекты не равны.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Note))
            {
                return false;
            }

            Note other = (Note)obj;

            return this.LastName != other.LastName
                || this.Name != other.Name
                || this.Patronymic != other.Patronymic
                || this.Street != other.Street
                || this.House != other.House
                || this.Flat != other.Flat
                || this.Phone != other.Phone;
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ Name.GetHashCode() ^ Patronymic.GetHashCode() ^ Street.GetHashCode() ^ House ^ Flat ^ Phone.GetHashCode();
        }
    }


}
