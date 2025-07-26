using LMS.System.Domain.Services.CourseServices.CourseService;
using X.PagedList;

namespace LMS.System.Domain.Services.CourseServices.Interface
{
    /// <summary>
    /// Интерфейс реализующий методы для работы с курсами.
    /// </summary>
    public interface ICourseService
    {
        /// <summary>
        /// Пагинация для курсов.
        /// </summary>
        /// <param name="request">Демо-курс.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Пагинированный список.</returns>
        Task<IPagedList<CourseResponse>> GetCoursePageAsync(CourseRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Получения курса по id.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Найденный курс.</returns>
        Task<CourseResponse?> GetCourseByIdAsync(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Метод создания курса.
        /// </summary>
        /// <param name="request">Демо-курс.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        Task<int> CreateCourseAsync(CourseRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Метод обновления данный курса.
        /// </summary>
        /// <param name="request">Курс.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        Task UpdateCourseAsync(CourseRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// метод удаления курса.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        Task DeleteCourseAsync(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Метод публикации курса.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        Task PublishCourseAsync(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Метод для архивирования курсов.
        /// </summary>
        /// <param name="id">Id курса.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Ничего.</returns>
        Task ArchiveCourseAsync(int id, CancellationToken cancellationToken);
    }
}
