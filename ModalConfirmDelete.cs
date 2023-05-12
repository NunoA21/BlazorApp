public class ModalConfirmDelete{
    public string? ModalId { get; set; } = Guid.NewGuid().ToString();
    public string? ModalDisplay { get; set; } = "none";
    public string? ModalClass { get; set; } = "";
    public bool ShowBackdrop { get; set; } = false;

    public void OpenModalClearTodo(){
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
    }

    public void CloseModalClearTodo(){
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
    }
}