using AvonovaVacation.Models;

namespace AvonovaVacation.Services;

public static class VacationRequestService
{
    static List<VacationRequest> VacationRequests { get; }

    static VacationRequestService()
    {
        VacationRequests = new List<VacationRequest>
        {

        };
    }

    public static List<VacationRequest> GetAll() => VacationRequests;

    public static VacationRequest? Get(int id) => VacationRequests.FirstOrDefault(p => p.Id == id);

    public static async void AddVacationRequestForEmployee(int employeeId, VacationRequest vacationRequest)
    {
        var employee = EmployeeService.Get(employeeId);
        if (employee == null)
            return;

        vacationRequest.Id = VacationRequests.Count + 1;
        vacationRequest.EmployeeId = employeeId;
        vacationRequest.Pending = true;
        vacationRequest.Approved = false;
        vacationRequest.Denied = false;

        employee.VacationRequest = vacationRequest;

        VacationRequests.Add(vacationRequest);
    }

    public static async void ApproveVacationRequest(int id)
    {

        var vacationRequest = Get(id);
        if (vacationRequest == null)
            return;

        vacationRequest.Approved = true;
        vacationRequest.Denied = false;
        vacationRequest.Pending = false;

        var employee = EmployeeService.Get(vacationRequest.EmployeeId);
        if (employee == null)
            return;

        employee.VacationDaysLeft -= vacationRequest.DaysRequested;
        employee.VacationDaysUsed += vacationRequest.DaysRequested;
    }

    public static void DenyVacationRequest(int id)
    {
        var vacationRequest = Get(id);
        if (vacationRequest == null)
            return;

        vacationRequest.Approved = false;
        vacationRequest.Denied = true;
        vacationRequest.Pending = false;
    }

}