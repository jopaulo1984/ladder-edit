Public Class LDEdit

  Sub New()

  End Sub

  Public Overrides Function ToString() As String
    Return ""
  End Function

#Region "Métodos e Funções privadas"

  '--------- Eventos do mouse --------------
  Private Sub __mouse_click(ByVal mevt As LDMouseEvent)

  End Sub

  Private Sub __mouse_dbl_click(ByVal mevt As LDMouseEvent)

  End Sub

  Private Sub __mouse_move(ByVal mevt As LDMouseEvent)

  End Sub

  '-------- Eventos do botao do mouse ----------
  Private Sub __btn_pressed(ByVal mevt As LDMouseEvent)

  End Sub

  Private Sub __btn_released(ByVal mevt As LDMouseEvent)

  End Sub

  '---------------------------------------------
  Private Sub __dg_on_resized(ByVal dg As Object, ByVal w As Integer, ByVal h As Integer)

  End Sub

  Private Sub __controls_on_removed(ByVal cs, ByVal c)

  End Sub

  Private Sub __controls_on_appended(ByVal cs, ByVal c)

  End Sub

  Private Sub __set_dg_xml(ByVal sxml As String)

  End Sub

  '------ undo e redo ---------
  Private Sub __ur_reset()

  End Sub

  Private Sub __ur_save()

  End Sub

  Private Function __ur_can_update() As Boolean
    Return False
  End Function

  '----------------------------
  Private Sub __set_from_xml(ByVal sxml As String)

  End Sub

  Private Sub __desloc_marks(ByVal srow, ByVal drows)

  End Sub

#End Region

#Region "Métodos e Fuções públicas"

  'getters ------------
  Public Function GetYPositionFromLine(ByVal lineindex As Integer) As Integer
    Return 0
  End Function

  Public Function GetCommentFromPosition(ByVal x As Integer, ByVal y As Integer)
    Return Nothing
  End Function

  Public Function GetDiagram()
    Return Nothing
  End Function

  Public Function GetXML()
    Return ""
  End Function

  Public Function GetControls() As ArrayList
    Return New ArrayList
  End Function

  Public Function GetSize() As Size
    Return New Size(200, 100)
  End Function

  Public Function GetSimulationState() As Integer
    Return 0
  End Function

  Public Function GetMouseEventObject()
    Return New LDMouseEvent
  End Function

  Public Function GetSelection() As ArrayList
    Return New ArrayList
  End Function

  Public Function GetComments() As ArrayList
    Return New ArrayList
  End Function

  Public Function GetNetworksRows() As ArrayList
    Return New ArrayList
  End Function

  Public Function GetMarks() As ArrayList
    Return New ArrayList
  End Function

  Public Function GetNetworkFromLine(ByVal index As Integer)
    Return Nothing
  End Function

  Public Function GetMarkFromLabel(ByVal label As String)
    Return Nothing
  End Function

  Public Function GetMarkFromLine(ByVal lindex As Integer)
    Return Nothing
  End Function

  Public Function GetControlFromAddress(ByVal address As String)
    Return Nothing
  End Function

  Public Function GetQuadrantFromPosition(ByVal x As Integer, ByVal y As Integer)
    Return Nothing
  End Function
  'fim getters -------------

  'setters -----------------
  Public Sub SetRowsColsCount(ByVal rows As Integer, ByVal cols As Integer)

  End Sub

  Public Sub SetName(ByVal value As String)

  End Sub

  Public Sub SetComponentToQuadrant(ByVal qdr, ByVal component, Optional ByVal change_event = True)

  End Sub

  Public Sub SetSelection(ByVal selection)

  End Sub
  'fim setter --------------

  '-------------------------
  Public Sub LoadFromXML(ByVal sxml As String)

  End Sub

  Public Sub LoadFromFile(ByVal fname As String)

  End Sub

  Public Sub SaveToFile(ByVal fname As String)

  End Sub

  Public Sub AddComponentToQuadrant(ByVal row As Integer, ByVal col As Integer)

  End Sub

  Public Sub ParallelStart(ByVal row As Integer, ByVal col As Integer)

  End Sub

  Public Sub ParallelEnd(ByVal row As Integer, ByVal col As Integer)

  End Sub

  Public Sub ClearQuadrant(ByVal qdr)

  End Sub

  Public Sub RemoveComponentOfQuadrant(ByVal qdr)

  End Sub

  Public Sub RemoveComponentsFromSelection()

  End Sub

  Public Sub RemoveFromAddress(ByVal address As String)

  End Sub

  Public Sub RemoveControl(ByVal control)

  End Sub

  Public Sub ClearSelection()

  End Sub

  Public Sub AppendToSelection(ByVal qdr)

  End Sub

  Public Sub InsertRow(ByVal qdr)
    'Insere uma linha no editor da seguinte forma:
    '  - se o quadrante selecionado estiver na primeira coluna, 
    '    a linha será inserida acima da linha do quadrante selecionado;
    '  - se o quadrante selecionado estiver em outras colunas, a linha
    '    será inserida abaixo da linha do quadrante selecionado.

  End Sub

  Public Sub InsertColumn(ByVal qdr)
    'Insere uma coluna no editor no lado esquerdo da 
    'coluna do quadrante selecionado.

  End Sub

  Public Sub RemoveRow(ByVal qdr)

  End Sub

  Public Sub RemoveColumn(ByVal qdr)

  End Sub

  Public Function isChanged() As Boolean
    Return False
  End Function

  Public Sub Connect(ByVal evt, ByVal callback)
    'Sinais do editor
    '=================

    'connect(event, callback)

    ':event: Eventos válidos para LDEdit.
    ':callback: Função a ser chamada quando o evento ocorrer.

    'O método `connect` é responsável por conectar uma função a um evento.
    'A função a ser conectadas deve ter o mesmo formato do evento conectado,
    'caso contrário, será retornado um erro de execução.

    'Eventos:
    '--------
    '* "clicked"
    '    Editor clicado. 

    '    formato: callback(edit)

    '* "left-clicked"
    '    Editor clicado com o botão esquerdo do mouse. 

    '    formato: callback(edit)

    '* "right-clicked"
    '    Editor clicado com o botão direito do mouse. 

    '    formato: callback(edit)

    '* "resized"
    '    Editor redimensionado. 

    '    formato: callback(edit, width, height)

    '* "changed"
    '    Alterações no editor.

    '    formato: callback(edit)

    '* "selection-changed"
    '    Seleção trocada.

    '    formato: callback(edit, selection)

    '    - selection - Quadrante selecionado.

    '* "component-hover"
    '    Mouse sobre um componente.

    '    formato: callback(edit, component)

    '    - component - Componente sob o mouse.

    '* "component-exit"
    '    Mouse sai de um componente.

    '    formato: callback(edit, component)

    '    - component - Componente que o mouse saiu.

    '* "component-dbl-click"
    '    duplo clique em um componente.

    '    formato: callback(edit, component)

    '    - component - Componente.

    '* "comment-selected"
    '    Comentário selecionado.

    '    formato: callback(edit, comment)

    '    - comment - comentário selecionado.

    '* "mark-selected"
    '    Marcação de linha selecionada.

    '    formato: callback(edit, mark)

    '    - mark - marcação selecionada.

    '* "control-added"
    '    Controle adicionado.

    '    formato: callback(edit)

    '* "control-removed"
    '    Controle removido.

    '    formato: callback(edit)

    '* "mouse-move"
    '    Movimento do mouse.

    '    formato: callback(edit, mouseevent) 

    '    - mouseevent - objeto da classe MouseEvent.

    '* "button-pressed"
    '    Botao do mouse pressionado.

    '    formato: callback(edit, mouseevent) 

    '    - mouseevent - objeto da classe MouseEvent.

    '* "button-released"
    '    Botao do mouse liberado.

    '    formato: callback(edit, mouseevent) 

    '    - mouseevent - objeto da classe MouseEvent.

    '* "message"
    '    Ocorre quando o editor gera alguma mensagem.

    '    formato: callback(edit, message)

  End Sub

  Public Function CanUndo() As Boolean
    Return False
  End Function

  Public Function CanRedo() As Boolean
    Return False
  End Function

  Public Sub undo()

  End Sub

  Public Sub Redo()

  End Sub

  Public Sub Copy()

  End Sub

  Public Sub Cut()

  End Sub

  Public Sub Paste()

  End Sub

  Public Sub ClearChanged()

  End Sub

  Public Sub InsertComments(ByVal x As Integer, ByVal y As Integer, ByVal text As String)

  End Sub

  Public Sub RemoveComments(ByVal comments As ArrayList)

  End Sub

  Public Sub InsertLineMark(ByVal line As Integer, ByVal label As String)

  End Sub

  Public Sub RemoveLineMark(ByVal mark)

  End Sub

  'do events ---------------------------
  Public Sub DoClicked(ByVal mevt As LDMouseEvent)

  End Sub

  Public Sub DoLeftClicked(ByVal mevt As LDMouseEvent)

  End Sub

  Public Sub DoRightClicked(ByVal mevt As LDMouseEvent)

  End Sub

  Public Sub DoChanged(Optional ByVal dochange = True, Optional ByVal ursave = True)

  End Sub

  Public Sub DoSelectionChanged(ByVal selection As ArrayList)

  End Sub

  Public Sub DoComponentDblClick(ByVal comp)

  End Sub

  Public Sub DoCommentsSelected(ByVal comments)

  End Sub

  Public Sub DoCommentsDblClick(ByVal comments)

  End Sub

  Public Sub DoMarkSelected(ByVal mark)

  End Sub

  Public Sub DoMarkDblClick(ByVal mark)

  End Sub

  'captação de eventos do ambiente gráfico
  Public Sub do_mouse_move(ByVal x, ByVal y)

  End Sub

  Public Sub do_button_press(ByVal x, ByVal y, ByVal button, Optional ByVal evt = Nothing)

  End Sub

  Public Sub do_button_release(ByVal x, ByVal y, ByVal button, ByVal evt)

  End Sub

  Public Sub do_key_press(ByVal key)

  End Sub

  Public Sub do_key_release(ByVal key)

  End Sub

  'simulação
  Public Sub StartSimulation(Optional ByVal intimefunc = Nothing)

  End Sub

  Public Sub PauseSimulation()

  End Sub

  Public Sub StopSimulation()

  End Sub

  'compilação
  Public Sub Compile(ByVal outfile As String)

  End Sub

  Public Sub ConverttoIL(ByVal directory As String)

  End Sub

#End Region

End Class
