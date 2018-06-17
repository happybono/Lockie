Imports System.Management

Public Class clsWMI

    Private objOS As ManagementObjectSearcher
    Private objCS As ManagementObjectSearcher
    Private objMgmt As ManagementObject
    Private m_strComputerName As String
    Private m_strManufacturer As String
    Private m_StrModel As String
    Private m_strOSName As String
    Private m_strOSVersion As String
    Private m_strSystemType As String
    Private m_strTPM As String
    Private m_strWindowsDir As String
    Private m_strCPUName As String
    Private m_strNofCores As String
    Private m_strNofLogicalProcessors As String
    Private m_strMaxClockSpeed As String

    Public Sub New()
        objOS = New ManagementObjectSearcher("SELECT * FROM WIN32_OperatingSystem")
        objCS = New ManagementObjectSearcher("SELECT * FROM WIN32_ComputerSystem")
        Dim objCPU As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")

        For Each Me.objMgmt In objOS.Get
            m_strOSName = objMgmt("name").ToString()
            m_strOSVersion = objMgmt("version").ToString()
            m_strComputerName = objMgmt("csname").ToString()
            m_strWindowsDir = objMgmt("windowsdirectory").ToString()
        Next

        For Each Me.objMgmt In objCS.Get
            m_strManufacturer = objMgmt("manufacturer").ToString()
            m_StrModel = objMgmt("model").ToString()
            m_strSystemType = objMgmt("systemtype").ToString()
            m_strTPM = objMgmt("totalphysicalmemory").ToString()
        Next

        For Each Me.objMgmt In objCPU.Get
            m_strCPUName = Me.objMgmt("Name").ToString()
            m_strNofCores = Me.objMgmt("NumberOfCores").ToString()
            m_strNofLogicalProcessors = Me.objMgmt("NumberOfLogicalProcessors").ToString()
            m_strMaxClockSpeed = Me.objMgmt("MaxClockSpeed").ToString()
        Next
    End Sub

    Public ReadOnly Property ComputerName()
        Get
            ComputerName = m_strComputerName
        End Get
    End Property

    Public ReadOnly Property Manufacturer()
        Get
            Manufacturer = m_strManufacturer
        End Get
    End Property

    Public ReadOnly Property Model()
        Get
            Model = m_StrModel
        End Get
    End Property

    Public ReadOnly Property OsName()
        Get
            OsName = m_strOSName
        End Get
    End Property

    Public ReadOnly Property OsVersion()
        Get
            OsVersion = m_strOSVersion
        End Get
    End Property

    Public ReadOnly Property SystemType()
        Get
            SystemType = m_strSystemType
        End Get
    End Property

    Public ReadOnly Property TotalPhysicalMemory()
        Get
            TotalPhysicalMemory = Val(m_strTPM / 1048576) + 1
        End Get
    End Property

    Public ReadOnly Property WindowsDirectory()
        Get
            WindowsDirectory = m_strWindowsDir
        End Get
    End Property

    Public ReadOnly Property CPUName()
        Get
            CPUName = m_strCPUName
        End Get
    End Property

    Public ReadOnly Property NumberOfCores()
        Get
            NumberOfCores = m_strNofCores
        End Get
    End Property

    Public ReadOnly Property NumberOfLogicalProcessors()
        Get
            NumberOfLogicalProcessors = m_strNofLogicalProcessors
        End Get
    End Property

    Public ReadOnly Property MaxClockSpeed()
        Get
            MaxClockSpeed = (m_strMaxClockSpeed / 1000)
        End Get
    End Property
End Class
