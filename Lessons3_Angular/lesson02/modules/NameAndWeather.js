"use strict";
var Name = (function () {
    function Name(name, second) {
        this.name = name;
        this.second = second;
    }
    Object.defineProperty(Name.prototype, "nameMessage", {
        get: function () {
            return "Hello " + this.name + " " + this.second;
        },
        enumerable: true,
        configurable: true
    });
    return Name;
}());
exports.Name = Name;
var WeatherLocation = (function () {
    function WeatherLocation(weather, city) {
        this.weather = weather;
        this.city = city;
    }
    Object.defineProperty(WeatherLocation.prototype, "weatherMessage", {
        get: function () {
            return "It is " + this.weather + " in " + this.city;
        },
        enumerable: true,
        configurable: true
    });
    return WeatherLocation;
}());
exports.WeatherLocation = WeatherLocation;
