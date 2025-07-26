using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.System.Domain.Services.CourseManagement.DTO
{
    /// <summary>
    /// DTO классс для создания курса.
    /// </summary>
    public class CourseCreateRequest
    {
        /// <summary>
        /// Заголовок курса.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Описание курса.
        /// </summary>
        public required string Description { get; set; }
    }
}
