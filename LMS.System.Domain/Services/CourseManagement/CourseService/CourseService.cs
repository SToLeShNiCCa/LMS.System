using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.System.Domain.Services.CourseServices.Interface;
using X.PagedList;

namespace LMS.System.Domain.Services.CourseServices.CourseService
{
    /// <summary>
    /// Класс для работы с курсами.
    /// </summary>
    public class CourseService : ICourseService
    {
        public Task ArchiveCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateCourseAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CourseResponse?> GetCourseByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<CourseResponse>> GetCoursePageAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task PublishCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
