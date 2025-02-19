using ChustKnife.Domain.Common.Entities;
using ChustKnife.Domain.Enums;

namespace ChustKnife.Domain.Entities;

public class User : AuditableEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public UserRole Role { get; set; }
}