var broadcastPathIntervalID;
$(document).ready(function(){
	$("#quickSearch").on('keyup', function(e) {
		
		if(e.keyCode==38)
		{
			var actualSel = $("#quickSearchResults li.active");			
			var sig = actualSel.prev();
			if(actualSel.length == 0)
				sig = $("#quickSearchResults li").last();
			actualSel.removeClass("active");
			sig.addClass("active");
			e.preventDefault();e.stopPropagation()
		}
		else if(e.keyCode==40)
		{
			var actualSel = $("#quickSearchResults li.active");			
			var sig = actualSel.next();
			if(actualSel.length == 0)
				sig = $("#quickSearchResults li").first();
			actualSel.removeClass("active");
			sig.addClass("active");
			e.preventDefault();e.stopPropagation()
		}
		else
		{
			clearTimeout(broadcastPathIntervalID);
			broadcastPathIntervalID = setTimeout(function() {
				console.log("GET");
				getSuggest();
				
			}, 200);	
		}	
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

					var imagenTipo = '';
					if (data[i].tipo == 'Teatro')
						imagenTipo = '<i style="opacity: 0.5" class="icon-star" title="Teatro"></i> '
					else if (data[i].tipo == 'Cine')
						imagenTipo = '<i style="opacity: 0.5" class="icon-film" title="Cine"></i> '
					else if (data[i].tipo == 'Concierto')
						imagenTipo = '<i style="opacity: 0.5" class="icon-music" title="Concierto"></i> '
					else
						console.log(data[i].tipo);
						
					var enlace = $("<a></a>", {
						html: imagenTipo+highlightText,
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