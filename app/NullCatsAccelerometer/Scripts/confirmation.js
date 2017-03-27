(function ($) {
  'use strict';

  var isOk = getURLParams('isOk');

  $(document).ready(docReady);

  function docReady() {
    // TODO: Update the dom based on the passed in URL params
    //console.log(isOk);
    if (isOk === '1') {
      $('body').addClass('is-ok');
    }
    else {
      $('body').addClass('not-ok');
    }
  }

  function getURLParams(sParam) {
    var sPageURL      = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
      var sParameterName = sURLVariables[ i ].split('=');
      if (sParameterName[ 0 ] === sParam) {
        return sParameterName[ 1 ];
      }
    }
  }

})(jQuery);
