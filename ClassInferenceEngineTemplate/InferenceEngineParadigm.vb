
''' <summary>
''' Based on the inference engine paradigm: Under Construction / Research
''' </summary>
Public Class InferenceEngineParadigm

    ''' <summary>
    ''' Execute Results
    ''' </summary>
    Public Class Execute
        'Execute result
    End Class

    ''' <summary>
    ''' Enter data into matches: Generate ConflictSet
    ''' </summary>
    Public Class Matches

        Public Sub New()

        End Sub

        ''' <summary>
        ''' returned ConflictSet
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property GeneratedConflictSet As ConflictSet
            Get
                Return mGeneratedConflictSet
            End Get
        End Property

        ''' <summary>
        ''' Check data vs rules
        ''' </summary>
        Public Sub Data()
            'Get The data
        End Sub

        ''' <summary>
        ''' Keep items fitting the Rule conditions (add to conflict Set)
        ''' </summary>
        Public Sub GenerateConflictSet()
            'Check data vs rules
            'Keep items fitting the Rule conditions (add to conflict Set)
        End Sub

        ''' <summary>
        ''' Check set against ruleset
        ''' </summary>
        Public Sub Rules()
            'List of rules and conditions
        End Sub

        Private mGeneratedConflictSet As ConflictSet
    End Class

    ''' <summary>
    ''' Add ConflictSet to Resolve : Generate Results
    ''' </summary>
    Public Class Resolve

        Public ReadOnly Property Results As ConflictItem
            Get
                Return mResults
            End Get
        End Property

        Public Sub Interrogate(ByVal _ConflictSet As ConflictSet, ByVal _Strategy As String)
            Select Case _Strategy
                Case "LEX:"
                        'LEX: Pick the rule that passes the most amounts of required tests
                Case "RECENCY"
                        'RECENCY: Pick the rule that is the most common or Recent
                Case "MeanEndsAynalasis"
                    'Means End Analysis : Combine rules (Lex & Recency)
            End Select
        End Sub

        'Interrogate ConflictSet :
        ':use strategy :
        Private mResults As New ConflictItem

    End Class

    ''' <summary>
    ''' items to be in Conflct set (Ruleset - RulesetItems should be the same shape)
    ''' </summary>
    Public Structure ConflictItem

        Dim Item As String
        Dim Rating As Integer

    End Structure

    ''' <summary>
    ''' Conflict items (Ruleset - RulesetItems should be the same shape)
    ''' </summary>
    Public Structure ConflictSet

        Public items As List(Of ConflictItem)

    End Structure

    Public Function StartInferenceEngine() As Boolean
        Dim ResultsFound As Boolean = False
        '1. Enter data into matches: Generate ConflictSet
        '2. Add ConflictSet to Resolve : Generate Results
        '3. Execute Results
        Return ResultsFound
    End Function

End Class
