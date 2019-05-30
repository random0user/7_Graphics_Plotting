#pragma once
#include "functions.h"
#include "fstream"

namespace Lab1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Main_Form
	/// </summary>
	public ref class Main_Form : public System::Windows::Forms::Form
	{
	public:
		Main_Form(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~Main_Form()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataVisualization::Charting::Chart^  graph;
	private: System::Windows::Forms::TextBox^  border_2;
	protected:

	protected:

	private: System::Windows::Forms::TextBox^  step;
	private: System::Windows::Forms::Label^  label_border;
	private: System::Windows::Forms::Label^  label_step;
	private: System::Windows::Forms::Button^  buton_plot;
	private: System::Windows::Forms::TextBox^  border_1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  C1;
	private: System::Windows::Forms::TextBox^  C2;
	private: System::Windows::Forms::Label^  label2;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::Windows::Forms::DataVisualization::Charting::ChartArea^  chartArea1 = (gcnew System::Windows::Forms::DataVisualization::Charting::ChartArea());
			System::Windows::Forms::DataVisualization::Charting::Legend^  legend1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Legend());
			System::Windows::Forms::DataVisualization::Charting::Series^  series1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Series());
			this->graph = (gcnew System::Windows::Forms::DataVisualization::Charting::Chart());
			this->border_2 = (gcnew System::Windows::Forms::TextBox());
			this->step = (gcnew System::Windows::Forms::TextBox());
			this->label_border = (gcnew System::Windows::Forms::Label());
			this->label_step = (gcnew System::Windows::Forms::Label());
			this->buton_plot = (gcnew System::Windows::Forms::Button());
			this->border_1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->C1 = (gcnew System::Windows::Forms::TextBox());
			this->C2 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->graph))->BeginInit();
			this->SuspendLayout();
			// 
			// graph
			// 
			chartArea1->Name = L"ChartArea1";
			this->graph->ChartAreas->Add(chartArea1);
			legend1->Name = L"Legend1";
			this->graph->Legends->Add(legend1);
			this->graph->Location = System::Drawing::Point(12, 11);
			this->graph->Name = L"graph";
			this->graph->Palette = System::Windows::Forms::DataVisualization::Charting::ChartColorPalette::EarthTones;
			series1->ChartArea = L"ChartArea1";
			series1->ChartType = System::Windows::Forms::DataVisualization::Charting::SeriesChartType::Spline;
			series1->Legend = L"Legend1";
			series1->Name = L"Series1";
			series1->XValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Double;
			series1->YValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Double;
			this->graph->Series->Add(series1);
			this->graph->Size = System::Drawing::Size(1150, 449);
			this->graph->TabIndex = 0;
			this->graph->Text = L"chart1";
			this->graph->Click += gcnew System::EventHandler(this, &Main_Form::graph1_Click);
			// 
			// border_2
			// 
			this->border_2->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->border_2->Location = System::Drawing::Point(195, 504);
			this->border_2->Name = L"border_2";
			this->border_2->Size = System::Drawing::Size(155, 30);
			this->border_2->TabIndex = 1;
			this->border_2->TextChanged += gcnew System::EventHandler(this, &Main_Form::border_TextChanged);
			// 
			// step
			// 
			this->step->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->step->Location = System::Drawing::Point(410, 504);
			this->step->Name = L"step";
			this->step->Size = System::Drawing::Size(103, 30);
			this->step->TabIndex = 2;
			this->step->TextChanged += gcnew System::EventHandler(this, &Main_Form::step_TextChanged);
			// 
			// label_border
			// 
			this->label_border->AutoSize = true;
			this->label_border->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label_border->Location = System::Drawing::Point(163, 476);
			this->label_border->Name = L"label_border";
			this->label_border->Size = System::Drawing::Size(218, 22);
			this->label_border->TabIndex = 3;
			this->label_border->Text = L"Граничное значение(до)";
			this->label_border->Click += gcnew System::EventHandler(this, &Main_Form::label_border_Click);
			// 
			// label_step
			// 
			this->label_step->AutoSize = true;
			this->label_step->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label_step->Location = System::Drawing::Point(437, 476);
			this->label_step->Name = L"label_step";
			this->label_step->Size = System::Drawing::Size(47, 22);
			this->label_step->TabIndex = 4;
			this->label_step->Text = L"Шаг";
			// 
			// buton_plot
			// 
			this->buton_plot->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->buton_plot->Location = System::Drawing::Point(1030, 497);
			this->buton_plot->Name = L"buton_plot";
			this->buton_plot->Size = System::Drawing::Size(124, 41);
			this->buton_plot->TabIndex = 5;
			this->buton_plot->Text = L"Начертить";
			this->buton_plot->UseVisualStyleBackColor = true;
			this->buton_plot->Click += gcnew System::EventHandler(this, &Main_Form::buton_plot_Click);
			/*// 
			// border_1
			// 
			this->border_1->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->border_1->Location = System::Drawing::Point(40, 501);
			this->border_1->Name = L"border_1";
			this->border_1->Size = System::Drawing::Size(100, 30);
			this->border_1->TabIndex = 6;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(76, 476);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(33, 22);
			this->label1->TabIndex = 7;
			this->label1->Text = L"От";
			// 
			// C1
			// 
			this->C1->Location = System::Drawing::Point(695, 510);
			this->C1->Name = L"C1";
			this->C1->Size = System::Drawing::Size(100, 20);
			this->C1->TabIndex = 8;
			// 
			// C2
			// 
			this->C2->Location = System::Drawing::Point(828, 510);
			this->C2->Name = L"C2";
			this->C2->Size = System::Drawing::Size(100, 20);
			this->C2->TabIndex = 9;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Times New Roman", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(733, 476);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(175, 22);
			this->label2->TabIndex = 10;
			this->label2->Text = L"Константы С1 и С2";*/
			// 
			// Main_Form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1244, 551);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->C2);
			this->Controls->Add(this->C1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->border_1);
			this->Controls->Add(this->buton_plot);
			this->Controls->Add(this->label_step);
			this->Controls->Add(this->label_border);
			this->Controls->Add(this->step);
			this->Controls->Add(this->border_2);
			this->Controls->Add(this->graph);
			this->Name = L"Main_Form";
			this->Text = L"Main_Form";
			this->Load += gcnew System::EventHandler(this, &Main_Form::Main_Form_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->graph))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		//================================================
	private: System::Void Main_Form_Load(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void border_TextChanged(System::Object^  sender, System::EventArgs^  e) 
	{


	}
	private: System::Void step_TextChanged(System::Object^  sender, System::EventArgs^  e) {
	}


	//Клик по кнопке построить график
	private: System::Void buton_plot_Click(System::Object^  sender, System::EventArgs^  e)
	{
		graph->Series[0]->Points->Clear(); // Почистить график
		//Конвертация в double
		double d_border2, d_step, error;
		try 
		{
			d_border2 = System::Convert::ToDouble(this->border_2->Text);
			d_step = System::Convert::ToDouble(this->step->Text);
			if (d_border2 > 14.5)
			{
				MessageBox::Show(this, "Слишком большое число введено. у -> 0");
				return;
			}
			if (d_border2 == 0)
			{
				MessageBox::Show(this, "Вам не нужно строить график функции на промежутке [0, 0]");
				return;
			}
			else if (d_border2 < 0)
			{
				MessageBox::Show(this, "Не строим график при х < 0");
				return;
			}
				
			//MessageBox::Show(d_border2.ToString());
		}
		catch (...) //А если будет ошибка
		{
			MessageBox::Show(this, "Ошибка при вводе данных. Введите корректные данные.");
			return;
		}
		//
		//Теперь конвертация в double была успешна
		//

		
		error = d_border2 / 1000;
		if (d_step<error || d_step>d_border2 / 2)
		{
			
			d_step = error;
			//MessageBox::Show(this, "Ошибка при вводе данных");
			//return;
		}


		//Полезно (int).ToString();
		//double interval = d_border2 / 10.0;

		graph->ChartAreas[0]->AxisX->Minimum = 0;
		graph->ChartAreas[0]->AxisX->Maximum = d_border2+0.05*d_border2;
		//graph->ChartAreas[0]->AxisX->IntervalAutoMode = System::Windows::Forms::DataVisualization::Charting::IntervalAutoMode::FixedCount;
		//System::Windows::Forms::DataVisualization::Charting::Title;
		//MessageBox::Show((graph->ChartAreas[0]->AxisX->Interval).ToString());
		graph->ChartAreas[0]->AxisX->Crossing = 0;
		graph->ChartAreas[0]->AxisY->Crossing = 0;
		graph->ChartAreas[0]->AxisX->Interval = d_border2/10;
		//graph->ChartAreas[0]->AxisX->Title = "Ось X ->";
		//graph->ChartAreas[0]->AxisX->LabelStyle->Format = "yyyy-MM-dd";


		step->Text = d_step.ToString();

		/*if (d_border2 <= 5)
			graph->ChartAreas[0]->AxisX->Interval = 0.1;
		else if (d_border2 <= 10)
			graph->ChartAreas[0]->AxisX->Interval = 1;
		else if (d_border2 <= 20)
			graph->ChartAreas[0]->AxisX->Interval = 2;
		else
			graph->ChartAreas[0]->AxisX->Interval = 5;*/
		

		std::ofstream log;
		log.open("log.txt");
		int counter = 0;
		double y;
		for (double i = 0; i < d_border2 ; i += d_step)
		{
			log << counter << ") \t";
			y = evaluate(i);
			log << counter << '\t' << i << "\t" << y << '\t';
			graph->Series[0]->Points->AddXY(i, y);
			log << counter++ << " OK"<< std::endl;				
		}

		/*double interval = graph->ChartAreas[0]->AxisX->Interval;
		MessageBox::Show(interval.ToString());
		//MessageBox::Show("Финал");*/

		graph->Series[0]->Points->AddXY(d_border2, evaluate(d_border2));
	}

	private: System::Void graph1_Click(System::Object^  sender, System::EventArgs^  e) {

	}
private: System::Void label_border_Click(System::Object^  sender, System::EventArgs^  e) {
}
};//====================================================

}
