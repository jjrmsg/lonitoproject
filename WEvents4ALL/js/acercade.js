var map;
var directionsDisplay;
var directionsService = new google.maps.DirectionsService();
function initialize() {


    directionsDisplay = new google.maps.DirectionsRenderer();

    var myLatlng = new google.maps.LatLng(38.270142, -0.686175);

    var myOptions2 = {
        zoom: 13,
        center: myLatlng,
        disableDefaultUI: true,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map2 = new google.maps.Map(document.getElementById('mapa_content'), myOptions2);
    directionsDisplay.setMap(map2);
    directionsDisplay.setOptions({ suppressMarkers: true });

    var markerLoc = new google.maps.Marker({
        position: myLatlng,
        map: map2,
        title: "Events4All",
        icon: 'img/layout/theater.png'
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
                    icon: 'img/layout/user.png'
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
                    icon: 'img/layout/user.png'
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

//Mapa de instalaciones
$(document).ready(function () {


    $('#instal area[href][title]').qtip({
        content: {
            text: false 
        },
        position: {
            target: 'mouse',
            adjust: { x: 13, y: 0 }
        },
        style: 'blue' 
    });




});