namespace MyAwesomeLib;

public class UACGetListRequestKTestDto
{
    public string? CtrlId { get; set; }

    public string? FrmId { get; set; }
    
    public int PageNumber { get; set; } = 1;

    public int PageSize { get; set; } = 10;
}
