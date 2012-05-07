var broadcastPathIntervalID;
$(document).ready(function(){
	$("#quickSearch").on('keyup', function() {
		
		clearTimeout(broadcastPathIntervalID);
		broadcastPathIntervalID = setTimeout(function() {
			console.log("GET");
			getSuggest();
			
		}, 200);		
	});	
	
	
	$("#quickSearch").on('blur', function(e) {		
		setTimeout(function () { 
			hideResults();
		}, 150);
	});	
	
	/*$("#quickSearch").on('focusin', function(e) {	
		if ($("#quickSearch").val() != "" && $("#quickSearchResults li").length > 0)
		{		
			showResults();
		}
	});*/
});


function getSuggest()
{
	$('#quickSearch').stop(true,true)
	if ($("#quickSearch").val() != "" )		
	{
		$.getJSON('/api/esp_suggest.aspx', { texto: $("#quickSearch").val() }, function (data) {
			/*$("#drawZone").empty();*/
			$("#quickSearchResults").empty();
			if (data.length > 0)
			{
				for (i in data)
				{
					var res = $("<li></li>", {
						click: function(e) {  
							e.stopPropagation();
						  }  
					}).appendTo("#quickSearchResults");
											
					var textIn = $("#quickSearch").val();
					var query = textIn.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g, '\\$&');
					var highlightText = data[i].titulo.replace(new RegExp('(' + query + ')', 'ig'), function ($1, match) {
						return '<strong>' + match + '</strong>'
					});					

					var enlace = $("<a></a>", {
						html: highlightText,
						href: "/espectaculo.aspx?id="+data[i].id
					}).appendTo(res);
				}
				
				showResults();
				
			}
			else
				hideResults();
		});			
	}			
	else
		hideResults();
}

function showResults()
{
	if(!$('#quickSearchWrap').hasClass('open'))
	{
		$('#quickSearchResults').css("display","none");	
		$('#quickSearchWrap').addClass("open");	
		$('#quickSearchResults').slideDown('fast', function() {
			$('#quickSearchResults').removeAttr("style"); 
		});
	}
}

function hideResults()
{
	$('#quickSearchResults').slideUp('fast', function() {
		$('#quickSearchWrap').removeClass("open"); 
		$('#quickSearchResults').removeAttr("style"); 
	});
}