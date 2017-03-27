(function ($) {
  'use strict';
  var sent = false;
  $(document).ready(docReady);

  function docReady() {
    $('.btn-no').click(function (e) {
      e.preventDefault();
      if (!sent) {
        sent = true;
        SendSms();
      }
    });
  }

  function SendSms() {
    var twilioSms = { name: 'Thomas', link: '' };
    var url       = 'http://localhost:55870/api/NullCats/SendMessage';
    $.post(url, twilioSms)
      .done(function (data) {
        var msg = 'Your top contacts ';
        for (var i = 0; i < data.length; i++) {
          msg += data[ i ];
        }
        msg += 'have been notified.';
        window.location.href = 'confirmation.html';
        //console.info(msg);
      });
  }
})(jQuery);

