using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    /// <summary>
    /// Класс доклада участника
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Идентификатор участника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тематика доклада
        /// </summary>
        public string Theme { get; set; } = null!;
        /// <summary>
        /// Название доклада
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Специальность, к которой относится доклад
        /// </summary>
        public string Speciality { get; set; } = null!;
        /// <summary>
        /// Идентификатор участника, к которому относится доклад
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Участник, к которому относится доклад
        /// </summary>
        public Person Person { get; set; } = null!;
    }
}
