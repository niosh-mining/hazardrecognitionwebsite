/*!  RD_TemplatePackage_3 2017-07-26 Build: 3.2.3.3 */
$(function(){var a={prevText:'<span class="icon-angle-left"></span><span class="hidden">'+CDC.Constants.get("previous")+"</span>",nextText:'<span class="icon-angle-right"></span><span class="hidden">'+CDC.Constants.get("next")+"</span>"},b={start:function(a){$(".flex-caption").show(),$(".slide-current-slide").text(a.currentSlide+1),$(".slide-total-slides").text(CDC.Constants.get("of")+" "+a.count),window.setTimeout(function(){$(a[0]).data("flexslider").resize()},1e3)},before:function(a){$(".slide-current-slide").text(a.animatingTo+1)}},c={};if("undefined"!=typeof flexobjs&&flexobjs.length>0){for(var d=0;d<flexobjs.length;d+=2){if(c={},c=$.extend(flexobjs[d+1],a),c=$.extend(flexobjs[d+1],b),c.pauseOnAction=!0,c.pauseOnHover=!0,c.keyboard=!0,c.multipleKeyboard=!0,flexobjs[d].thumbnailsPerPage){var e=flexobjs[d].thumbnailsPerPage,f=c.itemMargin,g=(e-1)*f;sliderWidth=$(flexobjs[d].id).width()-g,c.itemWidth=Math.floor(sliderWidth/e)}$(flexobjs[d].id).flexslider(c),log(flexobjs[d].id+" init"),$(flexobjs[d].id).find("a").each(function(){$(this).focus(function(){$(this).parent("li").addClass("carousel-item-focus")}),$(this).blur(function(){$(this).parent("li").removeClass("carousel-item-focus")}),$(this).click(function(){$(this).parent("li").removeClass("carousel-item-focus")})})}CDC.Constants.set("flexSliderVideoDomains",["youtube.com","youtube-nocookie.com","ytimg.com","vimeocdn.com"]);for(var h={aryVideoDomains:CDC.Constants.get("flexSliderVideoDomains"),aryQueue:[{strName:"carousel-slides",jqElements:$(".carousel .slides li img"),strClass:"playbtnSmall",strSrc:"/TemplatePackage/3.0/images/icon-play-512.png"},{strName:"slider-slides",jqElements:$(".slider .slides li img"),strClass:"playbtnBig",strSrc:"/TemplatePackage/3.0/images/icon-play-512.png",strTarget:"_blank"}]},i=h.aryQueue.length-1;i>-1;i--)h.currentSet=h.aryQueue[i],h.currentSet.jqElements.each(function(){h.jqCurrImage=$(this),h.strCurrImageSrc=h.jqCurrImage.attr("src").toLowerCase();for(var a=h.aryVideoDomains.length-1;a>-1;a--)h.strCurrDomain=""+h.aryVideoDomains[a],h.strCurrImageSrc.indexOf(h.strCurrDomain)>-1&&"slider-slides"===h.currentSet.strName&&(h.jqParentLink=h.jqCurrImage.parent("a"),h.jqParentLink.attr("target",h.currentSet.strTarget))});h.jqTranscriptAnchor=$("a.tp-transcript-link"),""===h.jqTranscriptAnchor.attr("href")?h.jqTranscriptAnchor.hide():h.jqTranscriptAnchor.show(),h.jqLocalMediaAnchor=$("a.tp-alt-source-link"),""===h.jqLocalMediaAnchor.attr("href")?h.jqLocalMediaAnchor.hide():h.jqLocalMediaAnchor.show(),$(".carousel").on("click","a",function(a){var b=$(this).attr("data-transcript")||"";void 0!==b&&h.jqTranscriptAnchor.length>0&&(b.length>0?(h.jqTranscriptAnchor.show().attr("href",b),CDC&&CDC.Policy&&CDC.Policy.Documents&&($('[class^="sprite-"]',h.jqTranscriptAnchor).remove(),CDC.Policy.Documents.updateAnchorIcon(h.jqTranscriptAnchor))):h.jqTranscriptAnchor.hide());var c=$(this).attr("data-alt-source")||"";void 0!==c&&h.jqLocalMediaAnchor.length>0&&(c.length>0?(h.jqLocalMediaAnchor.show().attr("href",c),CDC&&CDC.Policy&&CDC.Policy.Documents&&($('[class^="sprite-"]',h.jqLocalMediaAnchor).remove(),CDC.Policy.Documents.updateAnchorIcon(h.jqLocalMediaAnchor))):h.jqLocalMediaAnchor.hide())})}else log("Flexslider Not Configured Correctly")});