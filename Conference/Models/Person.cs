using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    /// <summary>
    /// Класс участника конференции
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Идентификатор участника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя участника
        /// </summary>
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Фамилия участника
        /// </summary>
        public string LastName { get; set; } = null!;
        /// <summary>
        /// Должность участника
        /// </summary>
        public string Role { get; set; } = null!;
        /// <summary>
        /// Номер телефона участника
        /// </summary>
        public string PhoneNumber { get; set; } = null!;
        /// <summary>
        /// Электронная почта участника
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// Доклады участника
        /// </summary>
        public List<Report> Reports { get; set; } = new List<Report>();
        /// <summary>
        /// Собрания, в которых участвует участник
        /// </summary>
        public List<Meeting> Meetings { get; set; } = new List<Meeting>();
    }
}
