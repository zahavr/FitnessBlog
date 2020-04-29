using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessBL.Model
{

    [Serializable]

    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime DateOfBirhtday { get; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }

        #endregion Свойства

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="dateOfBirhtday">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>


        public User(string name, Gender gender, DateTime dateOfBirhtday, double weight, double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }

            if( gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }
            if(dateOfBirhtday < DateTime.Parse("01.01.1920" ) || dateOfBirhtday >= DateTime.Now)
            {
                throw new ArgumentException("Неправильная дата рождения.", nameof(DateOfBirhtday));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен 0.", nameof(weight));
            }
            if (height <= 0)
                throw new ArgumentException("Рост не может быть меньше или равен 0.", nameof(height));
            {

            }

            #endregion Проверка условий

            Name = name;
            Gender = gender;
            DateOfBirhtday = dateOfBirhtday;
            Weight = weight;
            Height = height;


        }

        public override string ToString()
        {
            return Name;
        }
    }
}
