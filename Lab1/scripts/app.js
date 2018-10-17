       function sprawdzZwierze()
	   {
			var text = document.getElementById('zwierze').value;
			if(text.toLowerCase() == 'kot')
			{
				document.getElementById('Odpowiedz').innerHTML = 'Dobrze';
				document.getElementById('Odpowiedz').style.color = "green";
			}
			else
			{
				document.getElementById('Odpowiedz').innerHTML = 'Źle';
				document.getElementById('Odpowiedz').style.color = "red";
			}
	   }
		
		function sprawdzDodawanie()
		{
			if(document.getElementById('dodawanie').value == '4') 
			{
				document.getElementById('WynikDodawania').innerHTML = 'Tak wynik to 4';
				document.getElementById('WynikDodawania').style.color = "green";
			}
			else
			{
				document.getElementById('WynikDodawania').innerHTML = 'Zły wynik';
				document.getElementById('WynikDodawania').style.color = "red";
			}
			
		}
		
		function sprawdzOdejmowanie()
		{
			if(document.getElementById('odejmowanie').value == '5') 
			{
				document.getElementById('WynikOdejmowania').innerHTML = 'Tak wynik to 5';
				document.getElementById('WynikOdejmowania').style.color = "green";
			}
			else
			{
				document.getElementById('WynikOdejmowania').innerHTML = 'Zły wynik';
				document.getElementById('WynikOdejmowania').style.color = "red";
			}
		}