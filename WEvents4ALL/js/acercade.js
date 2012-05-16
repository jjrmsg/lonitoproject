var map;
var directionsDisplay;
var directionsService = new google.maps.DirectionsService();
function initialize() {


    directionsDisplay = new google.maps.DirectionsRenderer();

    var myLatlng = new google.maps.LatLng(38.270142, -0.686175);

    var myOptions = {
        zoom: 13,
        center: new google.maps.LatLng(38.267985, -0.699168),
        disableDefaultUI: true,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map = new google.maps.Map(document.getElementById('mapa_content'), myOptions);

    var myOptions2 = {
        zoom: 15,
        center: myLatlng,
        disableDefaultUI: true,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map2 = new google.maps.Map(document.getElementById('mapa_content2'), myOptions2);
    directionsDisplay.setMap(map2);
    directionsDisplay.setOptions({ suppressMarkers: true });

    var markerLoc = new google.maps.Marker({
        position: myLatlng,
        map: map2,
        title: "Events4All",
        icon: 'http://mapicons.nicolasmollet.com/wp-content/uploads/mapicons/shape-default/color-eda11d/shapecolor-color/shadow-1/border-dark/symbolstyle-contrast/symbolshadowstyle-dark/gradient-iphone/theater.png'
    });


    $("#geoloc").click(function () {
        // Try W3C Geolocation (Preferred)
        if (navigator.geolocation) {
            browserSupportFlag = true;
            navigator.geolocation.getCurrentPosition(function (position) {
                initialLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
                var start = initialLocation;
                var end = myLatlng;
                var mapBounds = new google.maps.LatLngBounds();
                map2.fitBounds(mapBounds);
                mapBounds.extend(initialLocation);
                mapBounds.extend(myLatlng);
                map2.setCenter(initialLocation);
                var markerUser = new google.maps.Marker({
                    position: initialLocation,
                    map: map2,
                    title: "Tu",
                    icon: 'http://mapicons.nicolasmollet.com/wp-content/uploads/mapicons/shape-default/color-ffc11f/shapecolor-color/shadow-1/border-dark/symbolstyle-contrast/symbolshadowstyle-dark/gradient-iphone/male-2.png'
                });
                var request = {
                    origin: start,
                    destination: end,
                    travelMode: google.maps.TravelMode.DRIVING
                };
                directionsService.route(request, function (result, status) {
                    if (status == google.maps.DirectionsStatus.OK) {
                        directionsDisplay.setDirections(result);
                    }
                });
            }, function () {
                handleNoGeolocation(browserSupportFlag);
            });
            // Try Google Gears Geolocation
        } else if (google.gears) {
            browserSupportFlag = true;
            var geo = google.gears.factory.create('beta.geolocation');
            geo.getCurrentPosition(function (position) {
                initialLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
                var start = initialLocation;
                var end = myLatlng;
                var mapBounds = new google.maps.LatLngBounds();
                map2.fitBounds(mapBounds);
                mapBounds.extend(initialLocation);
                mapBounds.extend(myLatlng);
                map2.setCenter(initialLocation);
                var markerUser = new google.maps.Marker({
                    position: initialLocation,
                    map: map2,
                    title: "Tu",
                    icon: 'http://mapicons.nicolasmollet.com/wp-content/uploads/mapicons/shape-default/color-ffc11f/shapecolor-color/shadow-1/border-dark/symbolstyle-contrast/symbolshadowstyle-dark/gradient-iphone/male-2.png'
                });
                var request = {
                    origin: start,
                    destination: end,
                    travelMode: google.maps.TravelMode.DRIVING
                };
                directionsService.route(request, function (result, status) {
                    if (status == google.maps.DirectionsStatus.OK) {
                        directionsDisplay.setDirections(result);
                    }
                });
            }, function () {
                handleNoGeoLocation(browserSupportFlag);
            });
            // Browser doesn't support Geolocation
        } else {
            browserSupportFlag = false;
            handleNoGeolocation(browserSupportFlag);
            alert("No soporta geoloc");
        }


    });
}

google.maps.event.addDomListener(window, 'load', initialize);