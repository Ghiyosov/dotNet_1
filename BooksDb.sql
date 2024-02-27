


CREATE TABLE Books
(
	Id SERIAL PRIMARY KEY,
	Title VARCHAR(250),
	Author VARCHAR(150),
	Discription text
)
SELECT * FROM Books

INSERT INTO Books(Title,Author,Discription)
VALUES('The Women: A Novel','Kristin Hannah','As green and inexperienced as the men sent to Vietnam to fight, Frankie is over-whelmed by the chaos and destruction of war. Each day is a gamble of life and death, hope and betrayal; friendships run deep and can be shattered in an instant. In war, she meets—and becomes one of—the lucky, the brave, the broken, and the lost.'),
      ('Medgar and Myrlie: Medgar Evers and the Love Story That Awakened America','Joy-Ann Reid','Myrlie Louise Beasley met Medgar Evers on her first day of college. They fell in love at first sight, married just one year later, and Myrlie left school to focus on their growing family.'),
	  ('Oath and Honor: A Memoir and a Warning','Liz Cheney','In the aftermath of the 2020 presidential election, Donald Trump and many around him, including certain other elected Republican officials, intentionally breached their oath to the Constitution: they ignored the rulings of dozens of courts, plotted to overturn a lawful election, and provoked a violent attack on our Capitol.   Liz Cheney, one of the few Republican officials to take a stand against these efforts, witnessed the attack first-hand, and then helped lead the Congressional Select Committee investigation into how it happened. In Oath and Honor, she tells the story of this perilous moment in our history, those who helped Trump spread the stolen election lie, those whose actions preserved our constitutional framework, and the risks we still face.'),
	  ('The Housemaid','Freida McFadden','And I cook a delicious meal for the whole family before heading up to eat alone in my tiny room on the top floor.'),
	  ('Bride','Ali Hazelwood','outcast—again. Her days of living in anonymity among the Humans are over: she has been called upon to uphold a historic peacekeeping alliance between the Vampyres and their mortal enemies, the Weres, and she sees little choice but to surrender herself in the exchange—again...'),
	  ('The Body Keeps the Score: Brain, Mind, and Body in the Healing of Trauma','Bessel van der Kolk M.D.','Trauma is a fact of life. Veterans and their families deal with the painful aftermath of combat; one in five Americans has been molested; one in four grew up with alcoholics; one in three couples have engaged in physical violence. Dr. Bessel van der Kolk, one of the world’s foremost experts on trauma, has spent over three decades working with survivors. In The Body Keeps the Score, he uses recent scientific advances to show how trauma literally reshapes both body and brain, compromising sufferers’ capacities for pleasure, engagement, self-control, and trust. He explores innovative treatments—from neurofeedback and meditation to sports, drama, and yoga—that offer new paths to recovery by activating the brain’s natural neuroplasticity. Based on Dr. van der Kolk’s own research and that of other leading specialists, The Body Keeps the Score exposes the tremendous power of our relationships both to hurt and to heal—and offers new hope for reclaiming lives.'),
	  ('Caste: The Origins of Our Discontents','Isabel Wilkerson','“As we go about our daily lives, caste is the wordless usher in a darkened theater, flashlight cast down in the aisles, guiding us to our assigned seats for a performance. The hierarchy of caste is not about feelings or morality. It is about power—which groups have it and which do not.”'),
	  ('How to Know a Person: The Art of Seeing Others Deeply and Being Deeply Seen','David Brooks','misunderstood. In How to Know a Person, Brooks sets out to help us do better, posing questions that are essential for all of us: If you want to know a person, what kind of attention should you cast on them? What kind of conversations should you have? What parts of a person’s story should you pay attention to?'),
	  ('5 Ingredients Mediterranean: Simple Incredible Food [American Measurements]','Jamie Oliver','With chapters including Salads, Soups and Sandwiches, Pasta, Vegetables, Pies and Parcels, Seafood, Fish, Chicken and Duck, Meat, and Desserts, you’ll find something for every day of the week, and every occasion.

Dishes include:

· Tender smoky eggplant
· Epic prawns & beans
· Rogue ratatouille risotto
· Sizzling squid
· Island salad
· Herby steak & crispy potatoes
· Easy fig tart
· Jools’ chocolate dreams

It''s a real celebration of hero Mediterranean flavors and ingredients – quick and easy recipes for exciting everyday cooking.')