using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.App.Pages;

public partial class EmployeeOverview
{
    private const string SMALL_SIZE = "-small.jpg";
    private const string IMAGE_URL = "https://gillcleerenpluralsight.blob.core.windows.net/person/";

    public List<Employee> Employees { get; set; } = default!;

    protected override void OnInitialized() => Employees = MockDataService.Employees;

}
