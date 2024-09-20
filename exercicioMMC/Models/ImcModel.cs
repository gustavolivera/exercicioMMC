namespace exercicioMMC.Models
{
	public class ImcModel
	{
        public double? Altura { get; set; }
        public double? Peso { get; set; }
        public double? Valor { get; set; }
        public string? Situacao { get; set; }

		public void Calcular()
		{
			Valor = Peso / Math.Pow(Altura.Value, 2);
			
			switch (Valor)
			{
				case < 18.5: Situacao = "Abaixo do peso";
					break;
				case < 25: Situacao = "Peso normal";
					break;
				case < 30: Situacao = "Sobrepeso";
					break;
				default: Situacao = "Obesidade";
					break;
			}
			

		}

		

	}

   
}
