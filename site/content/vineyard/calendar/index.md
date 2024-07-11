---
title: "Vineyard Calendar"
image: "images/vineyard/2024/PXL_20240424_vines.jpg"
description: "Vineyard Calendar"
date: 2024-07-08T12:00:00+06:00
draft: false
---

<div id='vineyardBlogCalendar'></div>
<div id='details'></div>

<script src='https://cdn.jsdelivr.net/npm/fullcalendar/index.global.min.js'></script>

<script src="https://cdn.jsdelivr.net/npm/@fullcalendar/google-calendar@6.1.14/index.global.min.js"></script>

<script>
  document.addEventListener('DOMContentLoaded', function() {
        const calendarEl = document.getElementById('vineyardBlogCalendar')
        const calendar = new FullCalendar.Calendar(calendarEl, {
          initialView: 'dayGridMonth',
            googleCalendarApiKey:'AIzaSyAQ2bxcegzYd6V_Qd0Bv2ixz7YlBt95J38',
            events: {
                googleCalendarId: '5741b799cd60ecf2f51ea7a786abc961e1c12886f56bfec1ac52cc95f961d7f6@group.calendar.google.com'
            },
            eventMouseEnter: ( mouseEnterInfo ) => { 
                document.getElementById('details').innerHTML = mouseEnterInfo.event.title;},
             eventMouseLeave: ( mouseEnterInfo ) => { 
                document.getElementById('details').innerHTML = 'Details...';}
        })
        calendar.render()
      });

</script>

