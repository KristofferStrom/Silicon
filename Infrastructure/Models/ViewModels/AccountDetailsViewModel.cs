namespace Infrastructure.Models.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo BasicInfo { get; set; } = null!;
    public AccountAddressInfo AddressInfo { get; set; } = null!;
}
