export class Name {
	name: string;
	second: string;
	constructor(name: string, second: string){
		this.name = name;		
		this.second = second;
	}
	
	get nameMessage() : string {
		return `Hello ${this.name} ${this.second}`;
	}
}

export class WeatherLocation {
	weather: string;
	city: string;
	constructor(weather: string, city: string){
		this.weather = weather;
		this.city = city;
	}
	
	get weatherMessage() : string {
		return `It is ${this.weather} in ${this.city}`;
	}
	
	
}
