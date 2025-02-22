using System.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Application.Services.CloudService.Clients.Abstractions
{
    public interface INoticeClient
    {
        Task<IApiResponse<NoticeTypeDTO[]>> Types();

        Task<IApiResponse<PagedModel<NoticeDTO>>> Table(Guid typeId, int index, int? size = null);

        Task<IApiResponse<NoticeDTO[]>> NewMsg(Guid typeId, DateTimeOffset? time);
    }
}
