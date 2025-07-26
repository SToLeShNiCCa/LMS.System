using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.System.Domain.Services.CourseManagement.CourseService;
using LMS.System.Domain.Services.CourseServices.Interface;
using X.PagedList;

namespace LMS.System.Domain.Services.CourseServices.CourseService
{
    /// <summary>
    /// Класс для работы с курсами.
    /// </summary>
    public class CourseService : ICourseService
    {
        /// <summary>
        /// Метод архивирования курса.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        public Task ArchiveCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод создания курса.
        /// </summary>
        /// <param name="request">Реквест для создания курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Созданный курс.</returns>
        public Task<int> CreateCourseAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод удаления курса.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        public Task DeleteCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод отображения информации о курсах.
        /// </summary>
        /// <param name="id">Id курсов.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Информация о курсах на странице.</returns>
        public Task<CourseResponse?> GetCourseByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Пагинация.
        /// </summary>
        /// <param name="request">Реквест курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Пагинированный список.</returns>
        public Task<IPagedList<CourseResponse>> GetCoursePageAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод публикации курса.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        public Task PublishCourseAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для обновления курса.
        /// </summary>
        /// <param name="request">Реквест обновления.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        public Task UpdateCourseAsync(CourseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
