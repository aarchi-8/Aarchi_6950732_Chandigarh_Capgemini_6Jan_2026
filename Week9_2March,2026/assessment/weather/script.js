const button = document.getElementById("checkWeather");
const cityInput = document.getElementById("cityInput");
const weatherInfo = document.getElementById("weatherInfo");
const weatherCard = document.getElementById("weatherCard");

button.addEventListener("click", function(){

    const city = cityInput.value.toLowerCase();

    let temp;
    let weather;

    // Mock weather data
    if(city === "paris"){
        temp = "22°C";
        weather = "Sunny";
    }
    else if(city === "london"){
        temp = "18°C";
        weather = "Rainy";
    }
    else if(city === "new york"){
        temp = "20°C";
        weather = "Cloudy";
    }
    else{
        temp = "25°C";
        weather = "Sunny";
    }

    weatherInfo.innerHTML = 
        "City: " + city + "<br> Temp: " + temp + "<br> Weather: " + weather;

    // Change background color based on weather
    if(weather === "Sunny"){
        weatherCard.style.backgroundColor = "yellow";
    }
    else if(weather === "Rainy"){
        weatherCard.style.backgroundColor = "lightblue";
    }
    else if(weather === "Cloudy"){
        weatherCard.style.backgroundColor = "lightgray";
    }

});