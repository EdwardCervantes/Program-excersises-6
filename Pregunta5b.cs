enum dia { DOM, LUN, MART, MIERCOLES = 8, JUEV, VIER, SAB }; 
//enum dias diapago;error
private void Window_Loaded(object sender, RoutedEventArgs e)
{
	dia diax;
	//enum dia { DOM, LUN, MART, MIERCOLES, JUEV, VIER, SAB }; error
	//enum { DOM, LUN, MART, MIERCOLES, JUEV, VIER, SAB } dia2X; error
	int i = (int)dia.MIERCOLES;
	diax = dia.LUN;
	//diax = 9; error
	//dia.LUN = dia.MIERCOLES; error
	//dia.LUN = 5; error
	int y = (int)dia.LUN + (int)dia.MART;
}