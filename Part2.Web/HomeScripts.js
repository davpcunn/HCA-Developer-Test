$(document).ready(function() {
  $( ".clickable" ).click(function() {
    var color = $(this).css("background-color");
    $("#selectedColor").css("background-color", color);
  });
  $("#selectedColor").click(function(){
    alert($(this).css("background-color"));
  })
});