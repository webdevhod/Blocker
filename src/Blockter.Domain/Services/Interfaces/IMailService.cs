using System.Threading.Tasks;
using Blockter.Domain.Entities;

namespace Blockter.Domain.Services.Interfaces;

public interface IMailService
{
    Task SendPasswordResetMail(User user);
    Task SendActivationEmail(User user);
    Task SendCreationEmail(User user);
}
