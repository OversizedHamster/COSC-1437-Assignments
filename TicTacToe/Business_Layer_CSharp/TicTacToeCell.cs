//Ethan Smith

namespace Business_Layer_CSharp
{
    public class TicTacToeCell
    {
        public int RowID { get; set; }
        public int ColID { get; set; }
        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
