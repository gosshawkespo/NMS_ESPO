Public Class clsLogFields
    Private _AccountLinkID As String
    Private _LogID As String
    Private _AccountID As String
    Private _AccountName As String
    Private _Platform As String
    Private _Version As String
    Private _GamerHandle As String
    Private _EntryTime As String
    Private _CurrentPosition As String
    Private _SystemName As String
    Private _OriginalSystemName As String
    Private _NewSystemName As String
    Private _SystemID As String
    Private _PlanetID As String
    Private _PlanetName As String
    Private _OriginalPlanetName As String
    Private _NewPlanetName As String
    Private _CurrentArea As String
    Private _GalacticRegion As String
    Private _CurrentNanites As String
    Private _CurrentUnits As String
    Private _CurrentQS As String
    Private _CurrentFM As String
    Private _CurrentSD As String
    Private _Brief As String
    Private _Comment1 As String
    Private _Comment2 As String
    Private _RTFComment1 As New RichTextBox
    Private _RTFComment2 As New RichTextBox
    Private _LogFile As String = "NMS_LOG_UPDATE"
    Private _myUserID As Integer
    Private _username As String
    Private _LastSaved As String
    Private _DALID As String
    Private _LogSavedBy As String

    Public Property AccountLinkID() As String
        Get
            AccountLinkID = _AccountLinkID
        End Get
        Set(value As String)
            _AccountLinkID = value
        End Set
    End Property

    Public Property LogID() As String
        Get
            LogID = _LogID
        End Get
        Set(value As String)
            _LogID = value
        End Set
    End Property

    Public Property AccountID() As String
        Get
            AccountID = _AccountID
        End Get
        Set(value As String)
            _AccountID = value
        End Set
    End Property

    Public Property AccountName() As String
        Get
            AccountName = _AccountName
        End Get
        Set(value As String)
            _AccountName = value
        End Set
    End Property

    Public Property Platform() As String
        Get
            Platform = _Platform
        End Get
        Set(value As String)
            _Platform = value
        End Set
    End Property

    Public Property Version() As String
        Get
            Version = _Version
        End Get
        Set(value As String)
            _Version = value
        End Set
    End Property

    Public Property GamerHandle() As String
        Get
            GamerHandle = _GamerHandle
        End Get
        Set(value As String)
            _GamerHandle = value
        End Set
    End Property

    Public Property EntryTime() As String
        Get
            EntryTime = _EntryTime
        End Get
        Set(value As String)
            _EntryTime = value
        End Set
    End Property

    Public Property CurrentPosition() As String
        Get
            CurrentPosition = _CurrentPosition
        End Get
        Set(value As String)
            _CurrentPosition = value
        End Set
    End Property

    Public Property SystemName() As String
        Get
            SystemName = _SystemName
        End Get
        Set(value As String)
            _SystemName = value
        End Set
    End Property

    Public Property OriginalSystemName() As String
        Get
            OriginalSystemName = _OriginalSystemName
        End Get
        Set(value As String)
            _OriginalSystemName = value
        End Set
    End Property

    Public Property NewSystemName() As String
        Get
            NewSystemName = _NewSystemName
        End Get
        Set(value As String)
            _NewSystemName = value
        End Set
    End Property

    Public Property SystemID() As String
        Get
            SystemID = _SystemID
        End Get
        Set(value As String)
            _SystemID = value
        End Set
    End Property

    Public Property PlanetID() As String
        Get
            PlanetID = _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property PlanetName() As String
        Get
            PlanetName = _PlanetName
        End Get
        Set(value As String)
            _PlanetName = value
        End Set
    End Property

    Public Property OriginalPlanetName() As String
        Get
            OriginalPlanetName = _OriginalPlanetName
        End Get
        Set(value As String)
            _OriginalPlanetName = value
        End Set
    End Property

    Public Property NewPlanetName() As String
        Get
            NewPlanetName = _NewPlanetName
        End Get
        Set(value As String)
            _NewPlanetName = value
        End Set
    End Property

    Public Property CurrentArea() As String
        Get
            CurrentArea = _CurrentArea
        End Get
        Set(value As String)
            _CurrentArea = value
        End Set
    End Property

    Public Property GalacticRegion() As String
        Get
            GalacticRegion = _GalacticRegion
        End Get
        Set(value As String)
            _GalacticRegion = value
        End Set
    End Property

    Public Property CurrentNanites() As String
        Get
            CurrentNanites = _CurrentNanites
        End Get
        Set(value As String)
            _CurrentNanites = value
        End Set
    End Property

    Public Property CurrentUnits() As String
        Get
            Return _CurrentUnits
        End Get
        Set(value As String)
            _CurrentUnits = value
        End Set
    End Property

    Public Property CurrentQS() As String
        Get
            Return _CurrentQS
        End Get
        Set(value As String)
            _CurrentQS = value
        End Set
    End Property
    '_CurrentFM
    Public Property CurrentFrigateModules() As String
        Get
            Return _CurrentFM
        End Get
        Set(value As String)
            _CurrentFM = value
        End Set
    End Property
    '_CurrentSD

    Public Property CurrentSalvagedData() As String
        Get
            Return _CurrentSD
        End Get
        Set(value As String)
            _CurrentSD = value
        End Set
    End Property

    Public Property Brief() As String
        Get
            Return _Brief
        End Get
        Set(value As String)
            _Brief = value
        End Set
    End Property

    Public Property Comment1() As String
        Get
            Return _Comment1
        End Get
        Set(value As String)
            _Comment1 = value
        End Set
    End Property

    Public Property Comment2() As String
        Get
            Comment2 = _Comment2
        End Get
        Set(value As String)
            _Comment2 = value
        End Set
    End Property

    Public Property RTFComment1() As RichTextBox
        Get
            RTFComment1 = _RTFComment1
        End Get
        Set(value As RichTextBox)
            _RTFComment1 = value
        End Set
    End Property

    Public Property RTFComment2() As RichTextBox
        Get
            RTFComment2 = _RTFComment2
        End Get
        Set(value As RichTextBox)
            _RTFComment2 = value
        End Set
    End Property

    Public Property LogFile() As String
        Get
            LogFile = _LogFile
        End Get
        Set(value As String)
            _LogFile = value
        End Set
    End Property

    Public Property myUserID() As String
        Get
            myUserID = _myUserID
        End Get
        Set(value As String)
            _myUserID = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Username = _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property LastSaved() As String
        Get
            LastSaved = _LastSaved
        End Get
        Set(value As String)
            _LastSaved = value
        End Set
    End Property

    Public Property DALID() As String
        Get
            DALID = _DALID
        End Get
        Set(value As String)
            _DALID = value
        End Set
    End Property
    '_LogSavedBy
    Public Property LogSavedBy() As String
        Get
            DALID = _LogSavedBy
        End Get
        Set(value As String)
            _LogSavedBy = value
        End Set
    End Property
End Class
