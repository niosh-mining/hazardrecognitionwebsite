HazRecKR = function () {

    var krpano;
    var clicked_points = [];
    var _userHazardImage;
    var _missedImage;
    var _canMarkPoints;
    var _inFocusHazId;

    function Initialize(imageLocation, userHazardImage, missImage, canMarkPoints, isCylinder) {
        _userHazardImage = userHazardImage;
        _missedImage = missImage;
        _canMarkPoints = canMarkPoints;
        var html5option;
        if (isCylinder) {
            html5option = "always";
        } else {
            html5option = "never";
        }


        embedpano({ swf: imageLocation + ".swf", xml: imageLocation + ".xml", target: "pano", html5: html5option, mobilescale: 1.0, passQueryParameters: true });
        krpano = document.getElementById("krpanoSWFObject");
    }

    function Remove_Click(id) {
        krpano.call("removehotspot(" + id + ")");
        for (var i = 0; i < clicked_points.length; i++) {
            if (clicked_points[i].id == id) {
                clicked_points.splice(i, 1);
                return;
            }
        }
    }

    function Mouse_Clicked() {
        if (!_canMarkPoints)
            return;
        krpano.call("screentosphere(mouse.x, mouse.y, mouseath, mouseatv);");
        var h = krpano.get("mouseath");
        var v = krpano.get("mouseatv");
        var id = "a" + guid();
        krpano.call("addhotspot(" + id + ");");
        krpano.call("set(hotspot[" + id + "].url, " + _userHazardImage + ");");
        krpano.call("set(hotspot[" + id + "].ath," + h + ");");
        krpano.call("set(hotspot[" + id + "].atv," + v + ");");
        krpano.call("set(hotspot[" + id + "].onclick, js(HazRecKR.Remove_Click(" + id + ")));");
        clicked_points.push({ x: h, y: v, id: id });
    }

    function GetClickedPointsJSON() {
        return JSON.stringify(clicked_points);
    }

    function LookAt(h, v, hazId) {
        krpano.call("moveto(" + h + ", " + v + ", smooth)");

        if (typeof hazId != 'undefined') {
            HazRecKR.OnHotSpotFocus("a" + hazId.toString(), true);
        }
    }

    function DrawMiss(h, v) {
        var id = "a" + guid();
        krpano.call("addhotspot(" + id + ");");
        krpano.call("set(hotspot[" + id + "].url, " + _missedImage + ");");
        krpano.call("set(hotspot[" + id + "].ath, " + h + ");");
        krpano.call("set(hotspot[" + id + "].atv, " + v + ");");
    }

    function DrawClick(h, v) {
        var id = "a" + guid();
        krpano.call("addhotspot(" + id + ");");
        krpano.call("set(hotspot[" + id + "].url, " + _missedImage + ");");
        krpano.call("set(hotspot[" + id + "].ath, " + h + ");");
        krpano.call("set(hotspot[" + id + "].atv, " + v + ");");
    }

    function GoToHazardSlide(index) {
        $("#results").slick("slickGoTo", index);
        HazRecKR.OnHotSpotFocus("a" + hazid.toString(), true);
    }

    function OnHotSpotFocus(id, lockFocus) {
        if (lockFocus === true) {
            krpano.call("set(hotspot[" + _inFocusHazId + "].fillalpha, .2);");
            _inFocusHazId = id;
        }
        krpano.call("set(hotspot[" +id + "].fillalpha, 0);");
    }

    function OnHotSpotLeaveFocus(id) {
        // if this is the item with locked focus, mousing out should not change it's highlight
        if (_inFocusHazId === id) {
            return;
        }
        krpano.call("set(hotspot[" + id + "].fillalpha, .2);");
    }

    function DrawHazard(points, selected, hazardIndex) {
        var id = "a" + hazardIndex.toString(); 

        krpano.call("addhotspot(" + id + ");");
        krpano.call("set(hotspot[" +id + "].fillalpha, 0.2);");
        krpano.call("set(hotspot[" +id + "].onclick, js(HazRecKR.GoToHazardSlide(" + hazardIndex + ")));");
        krpano.call("set(hotspot[" +id + "].onover, js(HazRecKR.OnHotSpotFocus(" + id + ", false)));");
        krpano.call("set(hotspot[" + id + "].onout, js(HazRecKR.OnHotSpotLeaveFocus(" + id + ")));");
        
        var color;
        if (selected) {
            color = "#00FF00";
            krpano.call("set(hotspot[" + id + "].bordercolor, 0x00FF00);");
            krpano.call("set(hotspot[" +id + "].fillcolor, 0xd6e9c6);");
        } else {
            color= "#FF0000";
            krpano.call("set(hotspot[" + id + "].bordercolor, 0xFF0000);");
            krpano.call("set(hotspot[" +id + "].fillcolor, 0xFF7F7F);");
        }

        for (var i = 0; i < points.length; i++)
        {
            krpano.call("set(hotspot[" +id + "].point[" +i + "].ath, " + points[i].X + ");");
            krpano.call("set(hotspot[" + id + "].point[" +i + "].atv, " + points[i].Y + ");");
        }

        
        //draw numeric text
        //parent container hotspot
        krpano.call("addhotspot(b" + id + ");");
        krpano.call("set(hotspot[b" + id + "].ath, " + points[0].X + ");");
        krpano.call("set(hotspot[b" + id + "].atv, " + points[0].Y + ");");
        krpano.call("set(hotspot[b" + id + "].type, container);");

        //actual text
        var textid = "text" + id;
        krpano.call("addplugin(" + textid + ");");
        krpano.call("set(plugin[" + textid + "].url, \"textfield.swf\"");
        krpano.call("set(plugin[" + textid + "].parent, hotspot[b" + id + "]);");
        krpano.call("set(plugin[" + textid + "].html, "+ (hazardIndex+1) + ");");
        krpano.call("set(plugin[" + textid + "].backgroundalpha, 0);");
        krpano.call("set(plugin[" + textid + "].css, color:" + color + ";font-size:42px;margin-left:10px;margin-top:40px;);");
        krpano.call("set(plugin[" + textid + "].align, left);");
        krpano.call("set(plugin[" +textid + "].onclick, js(HazRecKR.GoToHazardSlide(" +hazardIndex + ")));");
    }

    //get a random string that resembles a guid
    function guid() {
        function s4() {
        return Math.floor((1 +Math.random()) * 0x10000)
                .toString(16)
                .substring(1);
                }
        return s4() +s4() + '-' +s4() + '-' +s4() + '-' +
                s4() + '-' + s4() + s4() + s4();
                }

        function StartTimer(time, update, complete) {
              var start = new Date().getTime();
              var interval = setInterval(function() {
                  var now = time - (new Date().getTime() -start);
                  if (now <= 0) {
                      clearInterval(interval);
                      complete();
                  }
                      else update(now);
                      }, 100); // the smaller this number, the more accurate the timer will be
        }

      return {
        Initialize: Initialize,
        Remove_Click: Remove_Click,
        Mouse_Clicked: Mouse_Clicked,
        GetClickedPointsJSON: GetClickedPointsJSON,
        LookAt: LookAt,
        DrawMiss: DrawMiss,
        DrawClick: DrawClick,
        DrawHazard: DrawHazard,
        StartTimer: StartTimer,
        GoToHazardSlide: GoToHazardSlide,
        OnHotSpotFocus: OnHotSpotFocus,
        OnHotSpotLeaveFocus: OnHotSpotLeaveFocus
        }
}();