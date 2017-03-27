(function ($) {
  'use strict';

  var apiEndpoint = 'http://localhost:55870/api/NullCats';
  var accelerometerFired = false;
  var latitude    = 0;
  var longitude   = 0;
  var checkForIncidentInterval;

  $(document).ready(docReady);

  function docReady() {

    $('#fireAccelerometer').click(getLatLng);

    $('#nineElevenBtn').click(make911Call);
  }

  function getLatLng(e) {
    e.preventDefault();

    if (accelerometerFired === false) {
      console.info('Accelerometer has fired...');
      navigator.geolocation.getCurrentPosition(success, error);
      accelerometerFired = true;
      $('#fireAccelerometer').addClass('btn-accelerometer--fired');
    }
    else {
      console.info('The accelerometer has already fired!');
    }

    // https://developer.mozilla.org/en-US/docs/Web/API/Geolocation/Using_geolocation
    function success(position) {
      latitude  = position.coords.latitude;
      longitude = position.coords.longitude;

      checkIncidentTrue(latitude, longitude);
    }

    function error(msg) {
      console.error('There was an error getting your latitude and longitude');
    }
  }

  function checkIncidentTrue(latitude, longitude) {
    console.info('Checking incidents in your location...');

    var url = apiEndpoint + '/CheckIncidentTrue?latitude=' + latitude + '&longitude=' + longitude;

    // Make the API call right away
    //checkForIncident(url);
    // Start polling for incident reports
    checkForIncidentInterval = setInterval(checkForIncident, 5000, url);
  }

  function checkForIncident(url) {
    console.log('Checking for incident...');

    $.get(url, function (data) {
      if (data) {
          console.info('911 call has been recorded at your location (' + latitude + ', ' + longitude + '). Time: ' + new Date().toLocaleString());
          clearInterval(checkForIncidentInterval);
          setTimeout(function () {
              window.location.href = 'alert.html';
          }, 5000);
      }
      else {
        console.info('No Accident reported.');
      }
    })
      //.fail(console.error)
      //.done(console.log)
    ;
  }

  function make911Call(e) {
    e.preventDefault();

    if (accelerometerFired) {

      var url = apiEndpoint + '/Make911Call';

      // Stop the incident polling and then start it up again
      clearInterval(checkForIncidentInterval);

      $.get(url, function () {

      })
        //.fail(console.error)
        //.done(console.log)
      ;

      // Start incident report polling again
      checkIncidentTrue(latitude, longitude);
    }
    else {
      console.info('Sorry, the accelerometer hasn’t been fired yet')
    }
  }

})(jQuery);
