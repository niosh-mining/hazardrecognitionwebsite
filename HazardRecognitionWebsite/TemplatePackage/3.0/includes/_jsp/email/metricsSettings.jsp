<%@ taglib uri="//java.sun.com/jsp/jstl/core" prefix="c" %>
	s.pageName = 'Sent | ' + s.pageName;
	s.prop8 = "Email this page: Sent";
} else {
	s.pageName = document.title;
	s.prop8 = 'Email this page: Form';
}
s.channel = 'CDC CMS';
s.prop4 = 'Office of the Director (OD)' + ' ^ ' + '' + ' ^ ' + s.pageName;