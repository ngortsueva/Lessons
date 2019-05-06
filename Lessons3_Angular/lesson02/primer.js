"use strict";
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var NameAndWeather_1 = require("./modules/NameAndWeather");
var tempConverter_1 = require("./modules/tempConverter");
//console.log("Hello");
//console.log("Apples");
//console.log("Orange");
var myFunc = function () {
    console.log("Red Green Blue");
};
function myFunc2(name, weather) {
    console.log("Hello " + name + ".");
    var message = "It is " + weather + " today";
    console.log(message);
}
//myFunc();
//myFunc2("Nicole", "sunny"); 
var myData = {
    name: "Nicole",
    weather: "Sunny"
};
//console.log("Hello " + myData.name + ".");
//console.log("Today is " + myData.weather + ".");
var myData2 = {
    name: "Nicole",
    weather: "Sunny",
    print: function () {
        console.log("Hello " + this.name + "!!!");
        console.log("Today is " + this.weather + ".");
    }
};
//myData2.print();
var MyClass = (function () {
    function MyClass(name, weather) {
        this.name = name;
        this._weather = weather;
    }
    Object.defineProperty(MyClass.prototype, "weather", {
        get: function () {
            return "Today is " + this._weather + ".";
        },
        set: function (value) {
            this._weather = value;
        },
        enumerable: true,
        configurable: true
    });
    MyClass.prototype.print = function () {
        console.log("Hello " + this.name + "!!!");
        console.log(this.weather);
    };
    return MyClass;
}());
//let myData3 = new MyClass("Nicole", "Sunny");
//myData3.print();
var MySubClass = (function (_super) {
    __extends(MySubClass, _super);
    function MySubClass(name, weather, city) {
        _super.call(this, name, weather);
        this.city = city;
    }
    MySubClass.prototype.print = function () {
        _super.prototype.print.call(this);
        console.log("You are in " + this.city);
    };
    return MySubClass;
}(MyClass));
//let myData4 = new MySubClass("Nicole", "Sunny", "Stockgolm");
//myData4.print();
var myname = new NameAndWeather_1.Name("Nicole", "Parson");
var loc = new NameAndWeather_1.WeatherLocation("raining", "London");
console.log(myname.nameMessage);
console.log(loc.weatherMessage);
var cTemp = tempConverter_1.TempConverter.convertFtoC(38);
console.log("The temp is " + cTemp + "C");
