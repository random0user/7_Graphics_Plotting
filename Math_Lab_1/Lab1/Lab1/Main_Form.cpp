#include "Main_Form.h"
#include "cmath"
#include "functions.h"

using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
void Main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Lab1::Main_Form form;
	Application::Run(%form);
}


//======================================================================================================


//===============================================================

inline double evaluate(double x)
{
	return 0.5 * exp(-2 * x) * (x + exp(x)*(2*x - 3)*sin(x) - exp(x)*(x - 2)*x*cos(x));
}

/*double round(double x, int precision)
{
	int mul = 10;

	for (int i = 0; i < precision; i++)
		mul *= mul;
	if (x > 0)
		return floor(x * mul + .5) / mul;
	else
		return ceil(x * mul - .5) / mul;
}*/