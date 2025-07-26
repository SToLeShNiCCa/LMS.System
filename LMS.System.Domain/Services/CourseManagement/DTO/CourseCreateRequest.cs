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
        public required string Title { get; set; }

        public required string Description { get; set; }

        public bool IsPublished
    }
}
