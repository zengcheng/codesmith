﻿''------------------------------------------------------------------------------
'' <autogenerated>
''     This code was generated by a CodeSmith Template.
''
''     DO NOT MODIFY contents of this file. Changes to this
''     file will be lost if the code is regenerated.
'' </autogenerated>
''------------------------------------------------------------------------------

Imports System
Imports System.Linq

Namespace Tracker.Core.Data

    ''' <summary>
    ''' A base class for Linq entities that implements notification events.
    ''' </summary>
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    Public Partial MustInherit Class LinqEntityBase
       Implements System.ComponentModel.INotifyPropertyChanging
       Implements System.ComponentModel.INotifyPropertyChanged

        ''' <summary>
        ''' Initializes a new instance of the <see cref="LinqEntityBase"/> class.
        ''' </summary>
        Protected Sub New()
        End Sub

        #Region "Notification Events"

        ''' <summary>
        ''' Implements a PropertyChanged event.
        ''' </summary>
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        ''' <summary>
        ''' Raise the PropertyChanged event for a specific property.
        ''' </summary>
        ''' <param name="propertyName">Name of the property that has changed.</param>
        <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
            If PropertyChangedEvent IsNot Nothing Then
                RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub


        ''' <summary>
        ''' Implements a PropertyChanging event.
        ''' </summary>
        Public Event PropertyChanging As System.ComponentModel.PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

        ''' <summary>
        ''' Raise the PropertyChanging event for a specific property.
        ''' </summary>
        ''' <param name="propertyName">Name of the property that is changing.</param>
        <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Protected Overridable Sub SendPropertyChanging(ByVal propertyName As String)
            If PropertyChangingEvent IsNot Nothing Then
                RaiseEvent PropertyChanging(Me, New System.ComponentModel.PropertyChangingEventArgs(propertyName))
            End If
        End Sub
        #End Region

        #Region "Detach Methods"
        ''' <summary>
        ''' Gets a value indicating whether this instance is Added to the change tracking of <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <returns>
        ''' <c>true</c> if this instance is Added; otherwise, <c>false</c>.
        ''' </returns>
        Public Function IsAttached() As Boolean
            Return PropertyChangingEvent IsNot Nothing
        End Function

        ''' <summary>
        ''' Remove this instance from the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' Removeing the entity will allow it to be Added to another <see cref="System.Data.Linq.DataContext"/>.
        ''' </remarks>
        Public Overridable Sub Detach()
            PropertyChangingEvent = Nothing
            PropertyChangedEvent = Nothing
        End Sub

        ''' <summary>
        ''' Remove the specified <see cref="T:System.Data.Linq.EntitySet`1" />.
        ''' </summary>
        ''' <typeparam name="TEntity">The type of the entity.</typeparam>
        ''' <param name="entitySet">The <see cref="T:System.Data.Linq.EntitySet`1" /> to Remove.</param>
        ''' <param name="onAdd">Delegate for <see cref="M:System.Data.Linq.EntitySet`1.Add(`0)" />.</param>
        ''' <param name="onRemove">Delegate for <see cref="M:System.Data.Linq.EntitySet`1.Remove(`0)" />.</param>
        ''' <returns>A new <see cref="T:System.Data.Linq.EntitySet`1" /> with the list copied if it was loaded.</returns>
        Protected Shared Function Detach(Of TEntity As LinqEntityBase)(ByVal entitySet As System.Data.Linq.EntitySet(Of TEntity), ByVal onAdd As Action(Of TEntity), ByVal onRemove As Action(Of TEntity)) As System.Data.Linq.EntitySet(Of TEntity)
            If entitySet Is Nothing OrElse Not entitySet.HasLoadedOrAssignedValues Then
                Return New System.Data.Linq.EntitySet(Of TEntity)(onAdd, onRemove)
            End If

            ' copy list and Remove all entities
            Dim list = entitySet.ToList()
            For Each t As TEntity In list
                t.Detach()
            Next

            Dim newSet = New System.Data.Linq.EntitySet(Of TEntity)(onAdd, onRemove)
            newSet.Assign(list)
            Return newSet
        End Function

        ''' <summary>
        ''' Remove the specified <see cref="T:System.Data.Linq.EntityRef`1"/>.
        ''' </summary>
        ''' <typeparam name="TEntity">The type of the entity.</typeparam>
        ''' <param name="entity">The <see cref="T:System.Data.Linq.EntityRef`1"/> to Remove.</param>
        ''' <returns>A new <see cref="T:System.Data.Linq.EntityRef`1"/> with the entity Removeed.</returns>
        Protected Shared Function Detach(Of TEntity As LinqEntityBase)(ByVal entity As System.Data.Linq.EntityRef(Of TEntity)) As System.Data.Linq.EntityRef(Of TEntity)
            If Not entity.HasLoadedOrAssignedValue OrElse entity.Entity Is Nothing Then
                Return New System.Data.Linq.EntityRef(Of TEntity)()
            End If

            entity.Entity.Detach()
            Return New System.Data.Linq.EntityRef(Of TEntity)(entity.Entity)
        End Function

        ''' <summary>
        ''' Remove the specified lazy loaded value.
        ''' </summary>
        ''' <typeparam name="T">The type of the value.</typeparam>
        ''' <param name="value">The lazy loaded value.</param>
        ''' <returns>A new <see cref="T:System.Data.Linq.Link`1"/> that is Removeed.</returns>
        Protected Shared Function Detach(Of T)(ByVal value As System.Data.Linq.Link(Of T)) As System.Data.Linq.Link(Of T)
            If Not value.HasLoadedOrAssignedValue Then
                Return Nothing
            End If

            Return New System.Data.Linq.Link(Of T)(value.Value)
        End Function

        #End Region

        #Region "ToString"
        
        ''' <summary>
        ''' Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        ''' </summary>
        ''' <param name="indentLevel">The indent level.</param>
        ''' <param name="indentValue">The indent value.</param>
        ''' <returns>
        ''' A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        ''' </returns>
        Public Overloads Function ToEntityString(ByVal indentLevel As Integer, ByVal indentValue As String) As String
            Dim props As System.Reflection.PropertyInfo() = Me.GetType().GetProperties(System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.Public)
            Dim sb = New System.Text.StringBuilder()
            Dim value As Object = Nothing
            Dim includeProperty As Boolean = True

            For t As Integer = 0 To indentLevel
                sb.Append(indentValue)
            Next

            sb.AppendLine("{")

            For Each prop In props
                value = Nothing

                If prop.PropertyType Is GetType(Byte()) OrElse prop.PropertyType Is GetType(System.Data.Linq.Binary) Then
                    value = "<binary>"
                ElseIf prop.PropertyType Is GetType(System.Data.Linq.EntitySet(Of )) OrElse prop.PropertyType.BaseType Is GetType(LinqEntityBase) Then
                    includeProperty = False
                Else
                    Try
                        value = prop.GetValue(Me, Nothing)
                    Catch
                        value = "<exception>"
                    End Try
                End If

                If includeProperty Then
                    If value IsNot Nothing Then
                        value = value.ToString().Replace(vbCr & vbLf, " ").Replace(ControlChars.Lf, " "C).Replace(ControlChars.Tab, " "C)
                    End If

                    If value IsNot Nothing AndAlso value.ToString().Length > 50 Then
                        value = [String].Concat(value.ToString().Substring(0, 50), "...")
                    End If

                    For t As Integer = 0 To indentLevel
                        sb.Append(indentValue)
                    Next

                    sb.Append(prop.Name)
                    sb.Append(" = ")

                    sb.AppendLine(If(value IsNot Nothing, If(value.ToString().Length > 0, value.ToString(), "<empty>"), "<null>"))
                End If
            Next

            For t As Integer = 0 To indentLevel
                sb.Append(indentValue)
            Next

            sb.AppendLine("}")

            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Returns an XML <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        ''' </summary>
        ''' <returns>An XML <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.</returns>
        Public Function ToXml() As String
            Dim settings = New System.Xml.XmlWriterSettings()
            settings.Indent = True
            settings.OmitXmlDeclaration = True

            Dim sb = New System.Text.StringBuilder()
            Using writer = System.Xml.XmlWriter.Create(sb, settings)
                Dim serializer = New System.Runtime.Serialization.DataContractSerializer([GetType]())
                serializer.WriteObject(writer, Me)
            End Using

            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Returns a byte array that represents the current <see cref="T:System.Object"/>. 
        ''' </summary>
        ''' <returns>A byte array that represents the current <see cref="T:System.Object"/>.</returns>
        Public Function ToBinary() As Byte()
            Dim buffer As Byte()
            Using ms = New System.IO.MemoryStream()
                Using writer = System.Xml.XmlDictionaryWriter.CreateBinaryWriter(ms)
                    Dim serializer = New System.Runtime.Serialization.DataContractSerializer([GetType]())
                    serializer.WriteObject(writer, Me)
                    writer.Flush()

                    buffer = ms.ToArray()
                End Using
            End Using
            Return buffer
        End Function
        #End Region
    End Class
End Namespace