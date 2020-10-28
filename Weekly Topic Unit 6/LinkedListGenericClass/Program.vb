Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program

    class SimpleNodeUsedForTesting
        Public Property Name As String
        Public Property ANumber As integer
    end class

    Sub Main(args As String())
        Console.WriteLine("ProfReynolds NodeChains")
        Console.WriteLine()

        Dim linkedList = new LinkedList(Of SimpleNodeUsedForTesting)

        linkedList.AddLast(New SimpleNodeUsedForTesting With 
                              {
                              .Name = "Prof Reynolds",
                              .ANumber = 1
                              })

        linkedList.AddLast(New SimpleNodeUsedForTesting With 
                              {
                              .Name = "a Student",
                              .ANumber = 2
                              })

        linkedList.AddLast(New SimpleNodeUsedForTesting With 
                              {
                              .Name = "an other Student",
                              .ANumber = 3
                              })

        ParseListIterativly(linkedlist)
    End Sub

    Private Sub ParseListIterativly(linkedlist As LinkedList(Of SimpleNodeUsedForTesting))
        For Each simplenode As SimpleNodeUsedForTesting In linkedlist
            Console.WriteLine(simplenode.Name)
        Next
    End Sub


End Module
