namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos)
    {
        int i = 0;
        
        while(i < todos.Length){
            todos[i] = "done - " + todos[i];
            i++;
        }
        return todos;
    }
}
