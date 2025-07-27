using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.System.Domain.Services.CourseServices.CourseService
{
    /// <summary>
    /// Класс для отображения данных на странице.
    /// </summary>
    public class CourseResponse
    {
        /// <summary>
        /// Идентификатор курса.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок курса.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Описание курса.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Название категории к которому относится курс.
        /// </summary>
        public string? CategoryName { get; set; }

        /// <summary>
        /// Имя преподавателя.
        /// </summary>
        public string? InstructorName { get; set; }
    }
}
