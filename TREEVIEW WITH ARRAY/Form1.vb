Public Class Form1
    Dim arrPlanets(7) 'Planets
    Dim arrDwarfPlanets(4) ' Dwarf Planets
    Dim arrMoons() 'Moons

    Dim strPlanet As String
    Dim strDwarfPlanet As String

    Private Sub planet_Click(sender As Object, e As EventArgs) Handles planet.Click
        'Load All Planets Into Array
        arrPlanets(0) = "Mercury"
        arrPlanets(1) = "Venus"
        arrPlanets(2) = "Earth"
        arrPlanets(3) = "Mars"
        arrPlanets(4) = "Jupiter"
        arrPlanets(5) = "Saturn"
        arrPlanets(6) = "Uranus"
        arrPlanets(7) = "Neptune"
        For Each strPlanet In arrPlanets

            frsttreeview.Nodes.Add(strPlanet)
        Next


    End Sub

    Private Sub dwarfplanet_Click(sender As Object, e As EventArgs) Handles dwarfplanet.Click
        'Load All Dwarf Planets into Array
        arrDwarfPlanets(0) = "Pluto"
        arrDwarfPlanets(1) = "Ceres"
        arrDwarfPlanets(2) = "Eris"
        arrDwarfPlanets(3) = "Makemake"
        arrDwarfPlanets(4) = "Haumea"

        For Each strDwarfPlanet In arrDwarfPlanets

            frsttreeview.Nodes.Add(strDwarfPlanet)

        Next
    End Sub

    Private Sub frsttreeview_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles frsttreeview.AfterSelect

        If frsttreeview.SelectedNode IsNot Nothing Then
            Dim strSeltext As String = frsttreeview.SelectedNode.Text 'Get Selected Node Text

            Select Case strSeltext

                Case "Mercury"

                    frsttreeview.SelectedNode.Nodes.Add("No Moon")

                Case "Venus"

                    frsttreeview.SelectedNode.Nodes.Add("No Moon")

                Case "Earth"

                    frsttreeview.SelectedNode.Nodes.Add("The Moon")

                Case "Mars"

                    'Redimension Moon Array, Without preserving Its Contents
                    ReDim arrMoons(1) 'Two Elements

                    arrMoons(0) = "Phobos"
                    arrMoons(1) = "Deimos"

                    Dim i As Integer 'Loop Counter

                    For i = 0 To arrMoons.Length - 1 'Loop Through All Array Elements

                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i)) 'Add To Selected Node

                    Next i

                Case "Jupiter"

                    ReDim arrMoons(15) 'Jupiter's 16 Moons

                    arrMoons(0) = "Metis"
                    arrMoons(1) = "Adrastea"
                    arrMoons(2) = "Amalthea"
                    arrMoons(3) = "Thebe"
                    arrMoons(4) = "Io"
                    arrMoons(5) = "Europa"
                    arrMoons(6) = "Ganymede"
                    arrMoons(7) = "Callisto"
                    arrMoons(8) = "Leda"
                    arrMoons(9) = "Himalia"
                    arrMoons(10) = "Lysithea"
                    arrMoons(11) = "Elara"
                    arrMoons(12) = "Ananke"
                    arrMoons(13) = "Carme"
                    arrMoons(14) = "Pasiphae"
                    arrMoons(15) = "Sinope"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i)) 'Add

                    Next i
                Case "Saturn"

                    ReDim arrMoons(17)

                    arrMoons(0) = "Pan"
                    arrMoons(1) = "Atlas"
                    arrMoons(2) = "Prometheus"
                    arrMoons(3) = "Pandora"
                    arrMoons(4) = "Epimetheus"
                    arrMoons(5) = "Janus"
                    arrMoons(6) = "Mimas"
                    arrMoons(7) = "Enceladus"
                    arrMoons(8) = "Tethys"
                    arrMoons(9) = "Telesto"
                    arrMoons(10) = "Calypso"
                    arrMoons(11) = "Dione"
                    arrMoons(12) = "Helene"
                    arrMoons(13) = "Rhea"
                    arrMoons(14) = "Titan"
                    arrMoons(15) = "Hyperion"
                    arrMoons(16) = "Iapetus"
                    arrMoons(17) = "Phoebe"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        'Add All Saturn Moons
                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i))

                    Next i

                Case "Uranus"

                    ReDim arrMoons(20)

                    arrMoons(0) = "Cordelia"
                    arrMoons(1) = "Ophelia"
                    arrMoons(2) = "Bianca"
                    arrMoons(3) = "Cressida"
                    arrMoons(4) = "Desdemona"
                    arrMoons(5) = "Juliet"
                    arrMoons(6) = "Portia"
                    arrMoons(7) = "Rosalind"
                    arrMoons(8) = "Belinda"
                    arrMoons(9) = "Puck"
                    arrMoons(10) = "Miranda"
                    arrMoons(11) = "Ariel"
                    arrMoons(12) = "Umbriel"
                    arrMoons(13) = "Titania"
                    arrMoons(14) = "Oberon"
                    arrMoons(15) = "Caliban"
                    arrMoons(16) = "Sycorax"
                    arrMoons(17) = "Prospero"
                    arrMoons(18) = "Setebos"
                    arrMoons(19) = "Stephano"
                    arrMoons(20) = "Trinculo"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        'Add All Uranus Moons
                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i))

                    Next i

                Case "Neptune"

                    ReDim arrMoons(7)

                    arrMoons(0) = "Naiad"
                    arrMoons(1) = "Thalassa"
                    arrMoons(2) = "Despina"
                    arrMoons(3) = "Galatea"
                    arrMoons(4) = "Larissa"
                    arrMoons(5) = "Proteus"
                    arrMoons(6) = "Triton"
                    arrMoons(7) = "Nereid"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i))

                    Next i

                Case "Pluto" 'Dwarf Planet

                    ReDim arrMoons(2)

                    arrMoons(0) = "Charon"
                    arrMoons(1) = "Nix"
                    arrMoons(2) = "Hydra"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i))

                    Next i

                Case "Ceres" 'Dwarf Planet

                    frsttreeview.SelectedNode.Nodes.Add("No Moon")

                Case "Eris"

                    ReDim arrMoons(0)

                    arrMoons(0) = "Dysnomia"

                    frsttreeview.SelectedNode.Nodes.Add("Dysnomia") 'Not Needing a Loop For 1 Item!

                Case "Makemake"

                    frsttreeview.SelectedNode.Nodes.Add("No Moon")

                Case "Haumea"

                    ReDim arrMoons(1)

                    arrMoons(0) = "Hi'iaka"
                    arrMoons(1) = "Namaka"

                    Dim i As Integer

                    For i = 0 To arrMoons.Length - 1

                        frsttreeview.SelectedNode.Nodes.Add(arrMoons(i))
                    Next i
            End Select
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frsttreeview.Nodes.Clear()
    End Sub
End Class
