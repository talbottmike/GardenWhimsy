#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    description: string
}

let loader (projectRoot: string) (siteContent: SiteContents) =
    siteContent.Add({title = "Garden Whimsy"; description = "Repurposed whimsies for your home and garden"})
    //https://www.instagram.com/gardenwhimsyorg/
    siteContent
