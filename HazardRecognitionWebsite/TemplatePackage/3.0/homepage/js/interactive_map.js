//Gral Settings
jQuery(document).ready(function($) {
	
	//Load data to show when map loads first time
	d3.json("js/json1.json", function (error, json) {
        if (error) {
            console.log(error);
            return;
        }
        //console.log("Json file read");
        //console.log(json);
        drawMap(json);
		drawTable(json);

    });
	
	//Takes value of what's selected on dropdown menu
    $('#period').change(function () {
        updateMap(this.options[this.selectedIndex].value);
        //console.log(this.options[this.selectedIndex].value);
    });

	$('#textVersion').click(function () {
		$('#table_map').toggle();
	});
	
	
	
	//Load Data when option is selected on drop down menue
	function loadData(url) {
		d3.json(url, function (error, json) {
			if (error) return;
			//console.log(json);
			//console.log(url);
			//console.log("getting ready for the map");
			drawMap(json);
			drawTable(json);
	
		});
	}
	
	//Draw map
	function drawMap(data) {
		//console.log("1" + map);
		document.getElementById('map').innerHTML = "";
	
		var options = {
			data: data,
			element: document.getElementById('map'),
			scope: 'usa',
			fills: {
				'&gt;= 15.0': '#0062AB',
				'14.3 - 14.9': '#678EC7',
				'13.1 - 14.2': '#B8C7E6',
				'&lt;= 13.0': '#cfcfcf',
				'Insufficient Data': '#585858',
				defaultFill: '#d5d5d5'
			},
			geographyConfig: {
				borderColor: '#efefef',
				popupOnHover: true, //disable the popup while hovering
				highlightFillColor: '#d6f5ff',
				highlightBorderColor: '#393939',
				highlightBorderWidth: 2,
				popupTemplate: function (geo, data) {
					//console.log('Males: ' + data.Males);
					return ['<div class="hoverinfo"><strong>' + geo.properties.name + '</strong>',
						'<br/>Life expectancy : ' + data.Life_Expectancy,
						'</div>'].join('');
				},
			},
		};
	
		map = new Datamap(options);
		//Shows legends at the bottom of map
		map.legend();
		//Shows labels on each state
		map.labels();
		//console.log(map.options);
	
	}
	
	//Draw Table Text version
	function drawTable(json){	
		//$('#table_map').empty();	
		//console.log("Getting ready to draw table", json);
		//console.log(json);
		// Remove all existing rows before drawing new table
		$("tr:has(td)").remove();
		
		var table = $('<table>');
			var table_header_row = $('<tr>');
			var table_header_cell = $('<td>', {
				html: "State"
			});
			table_header_row.append(table_header_cell);
			var processedOnce = false;
			$.each(json, function (index, item) {
				var table_row = $('<tr>');
				//console.log(index);
				var table_cell = $('<td>', {
					html: index
				});
				table_row.append(table_cell);
				$.each(this, function (k, v) {
					var str = k.replace(/fillkey/i, "Legend"); 
					table_cell = $('<td>', {
						html: v
					});
					table_row.append(table_cell);
					if (!processedOnce) {
						table_header_cell = $('<td>', {
							html: str
						});
						//console.log(v);
						
						table_header_row.append(table_header_cell);
					}
				});
				if (!processedOnce) {
					processedOnce = true;
				}
				table.append(table_row);
			});
			table.prepend(table_header_row);
			$('#table_data').append(table);	
	}
	
	//Update map based on selection
	function updateMap(selectControl) {
		//// alert("UpdateMap function fired");
	
		switch (selectControl) {
		case "Period1":
			// console.log(selectControl + " selected");
			loadData("json1.json");
			$('#table_map').hide();
			break;
	
		case "Period2":
			// console.log(selectControl + " selected");
			loadData("json2.json");
			$('#table_map').hide();
			break;
	
		case "Period3":
			// console.log(selectControl + " selected");
			loadData("json3.json");
			$('#table_map').hide();
			break;
	
		default:
			//
		}
	
	}

	
});