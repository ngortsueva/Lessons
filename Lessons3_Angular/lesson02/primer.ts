import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { TempConverter } from "./modules/tempConverter";
//console.log("Hello");
//console.log("Apples");
//console.log("Orange");

let myFunc = function(){
	console.log("Red Green Blue");
};

function myFunc2(name, weather){
	
	console.log("Hello " + name + ".");
	let message = `It is ${weather} today`;
	console.log(message);
}

//myFunc();

//myFunc2("Nicole", "sunny"); 

let myData = {	
	name: "Nicole",
	weather: "Sunny"
};

//console.log("Hello " + myData.name + ".");
//console.log("Today is " + myData.weather + ".");

let myData2 = {
	name: "Nicole",
	weather: "Sunny",
	print: function(){
		console.log("Hello " + this.name + "!!!");
		console.log("Today is " + this.weather + ".");
	}
};

//myData2.print();

class MyClass {
	constructor(name, weather){
		this.name = name;
		this._weather = weather;
	}
	
	set weather(value){
		this._weather = value;
	}
	
	get weather(){
		return `Today is ${this._weather}.`;
	}
	
	print(){
		console.log("Hello " + this.name + "!!!");
		console.log(this.weather);
	}
}

//let myData3 = new MyClass("Nicole", "Sunny");
//myData3.print();

class MySubClass extends MyClass {
	constructor(name, weather, city){
		super(name, weather);
		this.city = city;
	}
	
	print(){
		super.print();
		console.log(`You are in ${this.city}`);
	}
}

//let myData4 = new MySubClass("Nicole", "Sunny", "Stockgolm");
//myData4.print();

let myname = new Name("Nicole", "Parson");
let loc = new WeatherLocation("raining", "London");

console.log(myname.nameMessage);
console.log(loc.weatherMessage);

let cTemp = TempConverter.convertFtoC(38);

console.log(`The temp is ${cTemp}C`);
















