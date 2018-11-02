'thumbsget - Gets the maxresdefault thumbnail for YouTube videos from
'original video URL. Not associated With YouTube or Google/Alphabet.
'Copyright (C) 2018 Drew Naylor
'YouTube and all related words are copyright
'and trademark Google/Alphabet. Explained more in About window.
'Google/Alphabet is not affiliated with either the thumbsget project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of thumbsget.
'
'thumbsget is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'thumbsget is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with thumbsget.  If not, see <http://www.gnu.org/licenses/>.




Public Class aaformMainWindow
    Private Sub buttonGetThumbnailInBrowser_Click(sender As Object, e As EventArgs) Handles buttonGetThumbnailInBrowser.Click
        ' First, make sure the textbox isn't empty.
        If Not textboxVideoUrl.Text.Length = 0 Then
            ' Look at the URL, and replace "www.youtube.com/watch?v=" with "i.ytimg.com/vi/".
            ' Actually, first replace "www." with "" (nothing).
            Dim thumbnailUrl As String = textboxVideoUrl.Text
            Debug.WriteLine("Start:")
            Debug.WriteLine("Current URL: " & thumbnailUrl)
            ' Replace "www." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("www.", "")
            Debug.WriteLine("Replace www. Current URL: " & thumbnailUrl)
            ' Replace "m." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("m.", "")
            Debug.WriteLine("Replace m. Current URL: " & thumbnailUrl)
            ' Replace "?feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("?feature=youtu.be", "")
            Debug.WriteLine("Replace ?feature=youtu.be. Current URL: " & thumbnailUrl)
            ' Replace "&feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&feature=youtu.be", "")
            Debug.WriteLine("Replace &feature=youtu.be. Current URL: " & thumbnailUrl)
            ' Now, if "youtube.com/watch?" is in the URL, replace it and "v=" with "i.ytimg.com/vi/".
            If thumbnailUrl.Contains("youtube.com/watch?") Then
                thumbnailUrl = thumbnailUrl.Replace("youtube.com/watch?v=", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtube.com/watch?v=. Current URL: " & thumbnailUrl)
            ElseIf thumbnailUrl.Contains("youtu.be/") Then
                ' If the URL contains "youtu.be/", replace that with "i.ytimg.com/vi/".
                thumbnailUrl = thumbnailUrl.Replace("youtu.be/", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtu.be. Current URL: " & thumbnailUrl)
            End If
            ' Replace "watch" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("watch", "")
            Debug.WriteLine("Replace watch. Current URL: " & thumbnailUrl)
            ' Replace "&v=" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&v=", "")
            Debug.WriteLine("Replace &v=. Current URL: " & thumbnailUrl)
            ' Once again, replace "youtube.com/" with "i.ytimg.com/vi/".
            thumbnailUrl = thumbnailUrl.Replace("youtube.com/", "i.ytimg.com/vi/")
            Debug.WriteLine("Replace youtube.com/. Current URL: " & thumbnailUrl)

            ' Add "maxresdefault.jpg" to end of URL.
            thumbnailUrl = thumbnailUrl & "/maxresdefault.jpg"
            Debug.WriteLine("Append /maxresdefault.jpg. Current URL: " & thumbnailUrl)

            ' Open in default browser.
            Process.Start(thumbnailUrl)
        End If
    End Sub

    Private Sub linklabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelAbout.LinkClicked
        ' thumbsget About window.
        ' It's really simple for now.
        MessageBox.Show(My.Application.Info.Title & vbCrLf &
                "Version " & My.Application.Info.Version.ToString & vbCrLf &
                My.Application.Info.Description & vbCrLf &
                My.Application.Info.Copyright & vbCrLf &
                vbCrLf &
                "You can get the code for thumbsget from:" & vbCrLf &
                "https://github.com/DrewNaylor/thumbsget/" & vbCrLf &
                vbCrLf &
                "Below is part of the Gnu GPLv3+ as it applies to " & My.Application.Info.Title & "." & vbCrLf &
                "Visit http://www.gnu.org/licenses/gpl.html for the full license." & vbCrLf &
                vbCrLf &
                "thumbsget is free software: you can redistribute it and/or modify" & vbCrLf &
                "it under the terms of the GNU General Public License as published by" & vbCrLf &
                "the Free Software Foundation, either version 3 of the License, or" & vbCrLf &
                "(at your option) any later version." & vbCrLf &
                vbCrLf &
                "thumbsget is distributed in the hope that it will be useful," & vbCrLf &
                "but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbCrLf &
                "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbCrLf &
                "GNU General Public License for more details." & vbCrLf &
                vbCrLf &
                "Copyright notice: YouTube and all related words and" & vbCrLf &
                "trademarks/registered trademarks owned by Google/Alphabet in the United States" & vbCrLf &
                "and/or other countries are Copyright 2018 Google/Alphabet. All" & vbCrLf &
                "Rights Reserved to Google/Alphabet for Google/Alphabet's copyrights, trademarks," & vbCrLf &
                "and registered trademarks." & vbCrLf &
                vbCrLf &
                "Any other companies mentioned own their respective copyrights/trademarks." & vbCrLf &
                vbCrLf &
                "Google/Alphabet is not affiliated with either the thumbsget project or" & vbCrLf &
                "Drew Naylor and does not endorse this software.", "About " & My.Application.Info.Title)
    End Sub
End Class
