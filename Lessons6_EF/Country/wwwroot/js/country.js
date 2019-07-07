function LoadRegions() {
    var countryid = document.getElementById("SelectedCountry").value;
    var regionUrl = `/City/RegionList?countryId=${countryid}`;
    $.ajax({
        url: regionUrl,

        success: function (data) {
            if (data != null) {
                var regions = JSON.parse(data);

                var regionList = document.getElementById("SelectedRegion");
                regionList.innerHTML = "";
                for (var i in regions) {
                    regionList.appendChild(new Option(regions[i].Name, regions[i].Id));
                }
            }
        }
    });
}

function LoadCities(selectedRegion) {
    var regionid = document.getElementById(selectedRegion).value;
    var regionUrl = `/City/CityList?regionId=${regionid}`;
    $.ajax({
        url: regionUrl,

        success: function (data) {
            if (data != null) {
                var cities = JSON.parse(data);

                var cityList = document.getElementById("SelectedCity");
                cityList.innerHTML = "";
                for (var i in cities) {
                    cityList.appendChild(new Option(cities[i].Name, cities[i].Id));
                }
            }
        }
    });
}

function LoadStreets(selectedCity) {
    var streetid = document.getElementById(element).value;
    var streetUrl = `/City/CityList?regionId=${streetid}`;
    $.ajax({
        url: streetUrl,

        success: function (data) {
            if (data != null) {
                var cities = JSON.parse(data);

                var cityList = document.getElementById("SelectedStreet");
                cityList.innerHTML = "";
                for (var i in cities) {
                    cityList.appendChild(new Option(cities[i].Name, cities[i].Id));
                }
            }
        }
    });
}