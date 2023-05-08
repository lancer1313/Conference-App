using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    /// <summary>
    /// Класс-модель собрания конференции
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// Идентификатор собрания
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Секция собрания
        /// </summary>
        public string Section { get; set; } = null!;
        /// <summary>
        /// Дата и время проведения собрания
        /// </summary>
        public string Date { get; set; } = null!;
        /// <summary>
        /// Участники конференции
        /// </summary>
        public List<Person> People { get; set; } = new List<Person>();
    }
}
